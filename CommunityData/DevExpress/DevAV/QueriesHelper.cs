namespace DevExpress.DevAV
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;

    public static class QueriesHelper
    {
        public static IQueryable<Order> ActualOrders(this IQueryable<Order> orders)
        {
            return Queryable.Where<Order>(orders, (Expression<Func<Order, bool>>)(x => x.OrderDate < DateTime.Now));
        }

        public static IQueryable<Quote> ActualQuotes(this IQueryable<Quote> quotes)
        {
            return Queryable.Where<Quote>(quotes, (Expression<Func<Quote, bool>>)(x => x.Date < DateTime.Now));
        }

        public static IQueryable<QuoteInfo> GetQuoteInfo(IQueryable<Quote> quotes)
        {
            return Queryable.Select<Quote, QuoteInfo>(QueriesHelper.ActualQuotes(quotes), (Expression<Func<Quote, QuoteInfo>>)(x => new QuoteInfo()
            {
                Id = x.Id,
                State = x.CustomerStore.Address.State,
                City = x.CustomerStore.Address.City,
                Date = x.Date,
                Total = x.Total,
                Opportunity = x.Opportunity
            }));
        }

        public static Decimal CustomSum<T>(this IEnumerable<T> query, Expression<Func<T, Decimal>> selector)
        {
            return Queryable.Sum(Queryable.DefaultIfEmpty<Decimal>(Queryable.Select<T, Decimal>(Queryable.AsQueryable<T>(query), selector), new Decimal(0)));
        }

        public static IEnumerable<CustomerSaleDetailOrderInfo> GetCustomerSaleDetails(long customerId, IQueryable<OrderItem> orderItems)
        {
            return (IEnumerable<CustomerSaleDetailOrderInfo>)Enumerable.ToArray<CustomerSaleDetailOrderInfo>(Enumerable.Select<IGrouping<long, CustomerSaleDetailOrderItemInfo>, CustomerSaleDetailOrderInfo>(Enumerable.GroupBy<CustomerSaleDetailOrderItemInfo, long>((IEnumerable<CustomerSaleDetailOrderItemInfo>)QueriesHelper.GetCustomerSaleOrderItemDetails(customerId, orderItems), (Func<CustomerSaleDetailOrderItemInfo, long>)(x => x.OrderId)), (Func<IGrouping<long, CustomerSaleDetailOrderItemInfo>, CustomerSaleDetailOrderInfo>)(x => new CustomerSaleDetailOrderInfo()
            {
                OrderId = x.Key,
                OrderItems = Enumerable.ToArray<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x),
                ProductCategory = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).ProductCategory,
                OrderDate = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).OrderDate,
                InvoiceNumber = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).InvoiceNumber,
                PONumber = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).PONumber,
                StoreCity = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).StoreCity,
                StoreId = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).StoreId,
                EmployeeFullName = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).EmployeeFullName,
                CustomerName = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).CustomerName,
                CustomerPhone = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).CustomerPhone,
                CustomerFax = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).CustomerFax,
                CustomerImage = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).CustomerImage,
                ShippingAmount = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).ShippingAmount,
                TotalAmount = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).TotalAmount,
                CustomerHomeOfficeLine = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).CustomerHomeOfficeLine,
                CustomerHomeOfficeCityLine = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).CustomerHomeOfficeCityLine,
                CustomerBillingAddressLine = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).CustomerBillingAddressLine,
                CustomerBillingAddressCityLine = Enumerable.First<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)x).CustomerBillingAddressCityLine
            })));
        }

        public static List<CustomerSaleDetailOrderItemInfo> GetCustomerSaleOrderItemDetails(long customerId, IQueryable<OrderItem> orderItems)
        {
            return Enumerable.ToList<CustomerSaleDetailOrderItemInfo>((IEnumerable<CustomerSaleDetailOrderItemInfo>)Queryable.Select<OrderItem, CustomerSaleDetailOrderItemInfo>(Queryable.Where<OrderItem>(orderItems, (Expression<Func<OrderItem, bool>>)(x => x.Order.CustomerId == (long?)customerId)), (Expression<Func<OrderItem, CustomerSaleDetailOrderItemInfo>>)(x => new CustomerSaleDetailOrderItemInfo()
            {
                ProductCategory = x.Product.Category,
                OrderDate = x.Order.OrderDate,
                OrderId = x.OrderId.Value,
                InvoiceNumber = x.Order.InvoiceNumber,
                PONumber = x.Order.PONumber,
                StoreId = x.Order.Store.Id,
                StoreCity = x.Order.Store.Address.City,
                EmployeeFullName = x.Order.Employee.FullName,
                CustomerName = x.Order.Customer.Name,
                CustomerPhone = x.Order.Customer.Phone,
                CustomerFax = x.Order.Customer.Fax,
                CustomerLogo = x.Order.Customer.Logo,
                CustomerHomeOfficeLine = x.Order.Customer.HomeOffice.Line,
                CustomerHomeOfficeCity = x.Order.Customer.HomeOffice.City,
                CustomerHomeOfficeZipCode = x.Order.Customer.HomeOffice.ZipCode,
                CustomerHomeOfficeState = x.Order.Customer.HomeOffice.State,
                CustomerBillingAddressLine = x.Order.Customer.BillingAddress.Line,
                CustomerBillingAddressCity = x.Order.Customer.BillingAddress.City,
                CustomerBillingAddressZipCode = x.Order.Customer.BillingAddress.ZipCode,
                CustomerBillingAddressState = x.Order.Customer.BillingAddress.State,
                Total = x.Total,
                TotalAmount = x.Order.TotalAmount,
                Discount = x.Discount,
                ProductUnits = x.ProductUnits,
                ProductPrice = x.ProductPrice,
                ShippingAmount = x.Order.ShippingAmount
            })));
        }

        public static IEnumerable<SaleSummaryInfo> GetSaleSummaries(IQueryable<OrderItem> orderItems)
        {
            return (IEnumerable<SaleSummaryInfo>)Enumerable.ToList<SaleSummaryInfo>((IEnumerable<SaleSummaryInfo>)Queryable.Select<OrderItem, SaleSummaryInfo>(orderItems, (Expression<Func<OrderItem, SaleSummaryInfo>>)(x => new SaleSummaryInfo()
            {
                OrderDate = x.Order.OrderDate,
                InvoiceNumber = x.Order.InvoiceNumber,
                ProductUnits = x.ProductUnits,
                ProductPrice = x.ProductPrice,
                Discount = x.Discount,
                Total = x.Total,
                ProductCategory = x.Product.Category,
                StoreId = x.Order.Store.Id,
                StoreCity = x.Order.Store.Address.City,
                StoreCustomerName = x.Order.Store.Customer.Name
            })));
        }

        public static IEnumerable<SaleAnalisysInfo> GetSaleAnalysis(IQueryable<OrderItem> orderItems)
        {
            return (IEnumerable<SaleAnalisysInfo>)Enumerable.ToList<SaleAnalisysInfo>((IEnumerable<SaleAnalisysInfo>)Queryable.Select<OrderItem, SaleAnalisysInfo>(orderItems, (Expression<Func<OrderItem, SaleAnalisysInfo>>)(x => new SaleAnalisysInfo()
            {
                OrderDate = x.Order.OrderDate,
                ProductCost = x.Product.Cost,
                ProductUnits = x.ProductUnits,
                Total = x.Total
            })));
        }

        public static IEnumerable<string> GetStateNames(IQueryable<State> queryableStates, IEnumerable<StateEnum> states)
        {
            return (IEnumerable<string>)Queryable.Join<State, StateEnum, StateEnum, string>(queryableStates, states, (Expression<Func<State, StateEnum>>)(ss => ss.ShortName), (Expression<Func<StateEnum, StateEnum>>)(s => s), (Expression<Func<State, StateEnum, string>>)((ss, s) => ss.LongName));
        }

        public static IList<OrderInfo> GetOrderInfo(IQueryable<Order> orders)
        {
            return (IList<OrderInfo>)Enumerable.ToList<OrderInfo>((IEnumerable<OrderInfo>)Queryable.Select<Order, OrderInfo>(QueriesHelper.ActualOrders(orders), (Expression<Func<Order, OrderInfo>>)(x => new OrderInfo()
            {
                InvoiceNumber = x.InvoiceNumber,
                OrderDate = x.OrderDate,
                Company = x.Customer.Name,
                Store = x.Customer.HomeOffice.City,
                TotalAmount = x.TotalAmount
            })));
        }

      //  public static List<Order> GetAverageOrders(IQueryable<Order> orders, int NumberOfPoints)
      //  {
      //      DateTime dateTime1 = Queryable.Min<Order, DateTime>(orders, (Expression<Func<Order, DateTime>>)(q => q.OrderDate));
      //      int daysPerGroup = Math.Max(1, (Queryable.Max<Order, DateTime>(orders, (Expression<Func<Order, DateTime>>)(q => q.OrderDate)) - dateTime1).Days / NumberOfPoints);
      //      DateTime constDate = new DateTime(1990, 1, 1);
      //      ParameterExpression parameterExpression;
      //      // ISSUE: method reference
      //      // ISSUE: type reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: type reference
      //      // ISSUE: method reference
      //      // ISSUE: type reference
      //      List<Decimal> list1 = Enumerable.ToList<Decimal>(Enumerable.Select < IGrouping < int, \u003C\u003Ef__AnonymousType0 < DateTime, Decimal >>, Decimal > (Enumerable.GroupBy(Enumerable.ToList(Queryable.Select(orders, Expression.Lambda < Func < Order, \u003C\u003Ef__AnonymousType0 < DateTime, Decimal >>> ((Expression)Expression.New((ConstructorInfo)MethodBase.GetMethodFromHandle(__methodref(\u003C\u003Ef__AnonymousType0<DateTime, Decimal>.\u002Ector), __typeref(\u003C\u003Ef__AnonymousType0<DateTime, Decimal>)), (IEnumerable<Expression>)new Expression[2]
      //      {
      //  (Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Order.get_OrderDate))),
      //  (Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Order.get_TotalAmount)))
      //      }, (MemberInfo[])new MethodInfo[2]
      //      {
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType0<DateTime, Decimal>.get_OrderDate), __typeref (\u003C\u003Ef__AnonymousType0<DateTime, Decimal>)),
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType0<DateTime, Decimal>.get_TotalAmount), __typeref (\u003C\u003Ef__AnonymousType0<DateTime, Decimal>))
      //      }), new ParameterExpression[1]
      //      {
      //  parameterExpression
      //      }))), q => (q.OrderDate - constDate).Days / daysPerGroup), g => Enumerable.Average(g, q => q.TotalAmount)));
      //      DateTime dateTime2 = dateTime1;
      //      List<Order> list2 = new List<Order>();
      //      foreach (Decimal num in list1)
      //      {
      //          list2.Add(new Order()
      //          {
      //              OrderDate = dateTime2,
      //              TotalAmount = num
      //          });
      //          dateTime2 = dateTime2.AddDays((double)daysPerGroup);
      //      }
      //      return list2;
      //  }

      //  public static List<Quote> GetAverageQuotes(IQueryable<Quote> quotes, int NumberOfPoints)
      //  {
      //      DateTime dateTime1 = Queryable.Min<Quote, DateTime>(quotes, (Expression<Func<Quote, DateTime>>)(q => q.Date));
      //      int daysPerGroup = Math.Max(1, (Queryable.Max<Quote, DateTime>(quotes, (Expression<Func<Quote, DateTime>>)(q => q.Date)) - dateTime1).Days / NumberOfPoints);
      //      DateTime constDate = new DateTime(1990, 1, 1);
      //      ParameterExpression parameterExpression;
      //      // ISSUE: method reference
      //      // ISSUE: type reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: type reference
      //      // ISSUE: method reference
      //      // ISSUE: type reference
      //      List<Decimal> list1 = Enumerable.ToList<Decimal>(Enumerable.Select < IGrouping < int, \u003C\u003Ef__AnonymousType1 < DateTime, Decimal >>, Decimal > (Enumerable.GroupBy(Enumerable.ToList(Queryable.Select(quotes, Expression.Lambda < Func < Quote, \u003C\u003Ef__AnonymousType1 < DateTime, Decimal >>> ((Expression)Expression.New((ConstructorInfo)MethodBase.GetMethodFromHandle(__methodref(\u003C\u003Ef__AnonymousType1<DateTime, Decimal>.\u002Ector), __typeref(\u003C\u003Ef__AnonymousType1<DateTime, Decimal>)), (IEnumerable<Expression>)new Expression[2]
      //      {
      //  (Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Quote.get_Date))),
      //  (Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Quote.get_Total)))
      //      }, (MemberInfo[])new MethodInfo[2]
      //      {
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<DateTime, Decimal>.get_Date), __typeref (\u003C\u003Ef__AnonymousType1<DateTime, Decimal>)),
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<DateTime, Decimal>.get_Total), __typeref (\u003C\u003Ef__AnonymousType1<DateTime, Decimal>))
      //      }), new ParameterExpression[1]
      //      {
      //  parameterExpression
      //      }))), q => (q.Date - constDate).Days / daysPerGroup), g => Enumerable.Average(g, q => q.Total)));
      //      DateTime dateTime2 = dateTime1;
      //      List<Quote> list2 = new List<Quote>();
      //      foreach (Decimal num in list1)
      //      {
      //          list2.Add(new Quote()
      //          {
      //              Date = dateTime2,
      //              Total = num
      //          });
      //          dateTime2 = dateTime2.AddDays((double)daysPerGroup);
      //      }
      //      return list2;
      //  }

      //  public static List<SalesInfo> GetSales(IQueryable<OrderItem> orderItems)
      //  {
      //      ParameterExpression parameterExpression;
      //      // ISSUE: method reference
      //      // ISSUE: type reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: type reference
      //      // ISSUE: method reference
      //      // ISSUE: type reference
      //      // ISSUE: method reference
      //      // ISSUE: type reference
      //      return Enumerable.ToList<SalesInfo>(Enumerable.Select < IGrouping < int, \u003C\u003Ef__AnonymousType2 < DateTime, ProductCategory, Decimal >>, SalesInfo > (Enumerable.GroupBy(Enumerable.ToList(Queryable.OrderBy(Queryable.Select(orderItems, Expression.Lambda < Func < OrderItem, \u003C\u003Ef__AnonymousType2 < DateTime, ProductCategory, Decimal >>> ((Expression)Expression.New((ConstructorInfo)MethodBase.GetMethodFromHandle(__methodref(\u003C\u003Ef__AnonymousType2<DateTime, ProductCategory, Decimal>.\u002Ector), __typeref(\u003C\u003Ef__AnonymousType2<DateTime, ProductCategory, Decimal>)), (IEnumerable<Expression>)new Expression[3]
      //      {
      //  (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (OrderItem.get_Order))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Order.get_OrderDate))),
      //  (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (OrderItem.get_Product))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Product.get_Category))),
      //  (Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (OrderItem.get_Total)))
      //      }, (MemberInfo[])new MethodInfo[3]
      //      {
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<DateTime, ProductCategory, Decimal>.get_OrderDate), __typeref (\u003C\u003Ef__AnonymousType2<DateTime, ProductCategory, Decimal>)),
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<DateTime, ProductCategory, Decimal>.get_ProductCategory), __typeref (\u003C\u003Ef__AnonymousType2<DateTime, ProductCategory, Decimal>)),
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<DateTime, ProductCategory, Decimal>.get_Total), __typeref (\u003C\u003Ef__AnonymousType2<DateTime, ProductCategory, Decimal>))
      //      }), new ParameterExpression[1]
      //      {
      //  parameterExpression
      //      })), x => x.OrderDate)), x => x.OrderDate.Year), x => new SalesInfo()
      //      {
      //          time = new DateTime(x.Key, 1, 1),
      //          Caption = "Sales (FY" + (object)x.Key + ")",
      //          ListProductInfo = Enumerable.ToList<SalesProductInfo>(Enumerable.Select < IGrouping < ProductCategory, \u003C\u003Ef__AnonymousType2 < DateTime, ProductCategory, Decimal >>, SalesProductInfo > (Enumerable.GroupBy(x, y => y.ProductCategory), y => new SalesProductInfo()
      //          {
      //              Name = y.Key.ToString(),
      //              Value = Enumerable.Sum(y, z => z.Total)
      //          }))
      //}));
      //  }

        public static IQueryable<ProductInfoWithSales> GetProductInfoWithSales(IQueryable<Product> products)
        {
            return Queryable.Select<Product, ProductInfoWithSales>(products, (Expression<Func<Product, ProductInfoWithSales>>)(x => new ProductInfoWithSales()
            {
                Id = x.Id,
                Name = x.Name,
                Cost = x.Cost,
                RetailPrice = x.RetailPrice,
                SalePrice = x.SalePrice,
                CurrentInventory = x.CurrentInventory,
                Backorder = x.Backorder,
                TotalSales = (Decimal?)Enumerable.Sum<OrderItem>(x.OrderItems, (Func<OrderItem, Decimal>)(orderItem => orderItem.Total))
            }));
        }

        public static void UpdateMonthlySales(IQueryable<OrderItem> orderItems, IEnumerable<ProductInfoWithSales> products)
        {
            foreach (ProductInfoWithSales productInfoWithSales in products)
            {
                ProductInfoWithSales productInfo = productInfoWithSales;
                productInfo.MonthlySales = (IEnumerable<double>)Enumerable.ToList<double>((IEnumerable<double>)Queryable.Select<IGrouping<int, OrderItem>, double>(Queryable.GroupBy<OrderItem, int>(Queryable.Where<OrderItem>(orderItems, (Expression<Func<OrderItem, bool>>)(x => x.Product.Id == productInfo.Id)), (Expression<Func<OrderItem, int>>)(x => x.Order.OrderDate.Month)), (Expression<Func<IGrouping<int, OrderItem>, double>>)(x => (double)Enumerable.Sum<OrderItem>(x, (Func<OrderItem, Decimal>)(i => i.Total)))));
            }
        }

        public static IQueryable<CustomerInfoWithSales> GetCustomerInfoWithSales(IQueryable<Customer> customers)
        {
            return Queryable.Select<Customer, CustomerInfoWithSales>(customers, (Expression<Func<Customer, CustomerInfoWithSales>>)(x => new CustomerInfoWithSales()
            {
                Id = x.Id,
                Name = x.Name,
                HomeOfficeLine = x.HomeOffice.Line,
                HomeOfficeCity = x.HomeOffice.City,
                HomeOfficeState = x.HomeOffice.State,
                HomeOfficeZipCode = x.HomeOffice.ZipCode,
                Phone = x.Phone,
                Fax = x.Fax,
                TotalSales = (Decimal?)Enumerable.Sum<Order>(x.Orders, (Func<Order, Decimal>)(orderItem => orderItem.TotalAmount))
            }));
        }

        //public static void UpdateCustomerInfoWithSales(IEnumerable<CustomerInfoWithSales> entities, IQueryable<CustomerStore> stores, IQueryable<CustomerEmployee> employees, IQueryable<Order> orders)
        //{
        //    foreach (CustomerInfoWithSales customerInfoWithSales in entities)
        //    {
        //        CustomerInfoWithSales item = customerInfoWithSales;
        //        // ISSUE: reference to a compiler-generated field
        //        // ISSUE: reference to a compiler-generated field
        //        item.Init((Func<IEnumerable<CustomerStore>>)(() => (IEnumerable<CustomerStore>)Enumerable.ToArray<CustomerStore>((IEnumerable<CustomerStore>)Queryable.Where<CustomerStore>(stores, (Expression<Func<CustomerStore, bool>>)(x => x.CustomerId == (long?)this.item.Id)))), (Func<IEnumerable<CustomerEmployee>>)(() => (IEnumerable<CustomerEmployee>)Enumerable.ToArray<CustomerEmployee>((IEnumerable<CustomerEmployee>)Queryable.Where<CustomerEmployee>(employees, (Expression<Func<CustomerEmployee, bool>>)(x => x.CustomerId == (long?)this.item.Id)))), (IEnumerable<Decimal>)Enumerable.ToArray<Decimal>((IEnumerable<Decimal>)Queryable.Select<IGrouping<int, Order>, Decimal>(Queryable.GroupBy<Order, int>(Queryable.Where<Order>(orders, (Expression<Func<Order, bool>>)(x => x.CustomerId == (long?)item.Id)), (Expression<Func<Order, int>>)(o => o.OrderDate.Month)), (Expression<Func<IGrouping<int, Order>, Decimal>>)(g => Enumerable.Sum<Order>(g, (Func<Order, Decimal>)(i => i.TotalAmount))))));
        //    }
        //}

        //public static IQueryable<Order> GetOrdersForPeriod(IQueryable<Order> orders, Period period, DateTime dateTime = null)
        //{
        //    switch (period)
        //    {
        //        case Period.ThisYear:
        //            return Queryable.Where<Order>(orders, (Expression<Func<Order, bool>>)(o => o.OrderDate.Year == DateTime.Now.Year));
        //        case Period.ThisMonth:
        //            return Queryable.Where<Order>(orders, (Expression<Func<Order, bool>>)(o => o.OrderDate.Month == DateTime.Now.Month && o.OrderDate.Year == DateTime.Now.Year));
        //        case Period.FixedDate:
        //            return Queryable.Where<Order>(orders, (Expression<Func<Order, bool>>)(o => o.OrderDate.Month == dateTime.Month && o.OrderDate.Year == dateTime.Year && o.OrderDate.Day == dateTime.Day));
        //        default:
        //            return orders;
        //    }
        //}

        //public static IQueryable<Order> GetCustomerOrdersForPeriod(IQueryable<Order> orders, Period period, long customerId)
        //{
        //    return QueriesHelper.GetOrdersForPeriod(Queryable.Where<Order>(orders, (Expression<Func<Order, bool>>)(o => o.CustomerId == (long?)customerId)), period, new DateTime());
        //}

        //public static IQueryable<OrderItem> GetOrderItemsForPeriod(IQueryable<OrderItem> orderItems, Period period, DateTime dateTime = null)
        //{
        //    return Queryable.Where<OrderItem>(orderItems, QueriesHelper.GetOrderItemsForPeriodFilter(period, dateTime));
        //}

        //public static Expression<Func<OrderItem, bool>> GetOrderItemsForPeriodFilter(Period period, DateTime dateTime = null)
        //{
        //    switch (period)
        //    {
        //        case Period.ThisYear:
        //            return (Expression<Func<OrderItem, bool>>)(x => x.Order.OrderDate.Year == DateTime.Now.Year);
        //        case Period.ThisMonth:
        //            return (Expression<Func<OrderItem, bool>>)(x => x.Order.OrderDate.Month == DateTime.Now.Month && x.Order.OrderDate.Year == DateTime.Now.Year);
        //        case Period.FixedDate:
        //            return (Expression<Func<OrderItem, bool>>)(x => x.Order.OrderDate.Month == dateTime.Month && x.Order.OrderDate.Year == dateTime.Year && x.Order.OrderDate.Day == dateTime.Day);
        //        default:
        //            return (Expression<Func<OrderItem, bool>>)(x => true);
        //    }
        //}

        //public static IEnumerable<CustomerStore> GetSalesStoresForPeriod(IQueryable<Order> orders, Period period = Period.Lifetime)
        //{
        //    return (IEnumerable<CustomerStore>)Queryable.Distinct<CustomerStore>(Queryable.Select<IGrouping<CustomerStore, Order>, CustomerStore>(Queryable.GroupBy<Order, CustomerStore>(QueriesHelper.GetOrdersForPeriod(orders, period, new DateTime()), (Expression<Func<Order, CustomerStore>>)(o => o.Store)), (Expression<Func<IGrouping<CustomerStore, Order>, CustomerStore>>)(g => g.Key)));
        //}

        //public static IEnumerable<MapItem> GetSaleMapItemsByCity(IQueryable<OrderItem> orderItems, long productId, string city, Period period = Period.Lifetime)
        //{
        //    return QueriesHelper.GetSaleMapItems(Queryable.Where<OrderItem>(orderItems, (Expression<Func<OrderItem, bool>>)(x => x.Order.Store.Address.City == city)), productId, period);
        //}

        //public static IEnumerable<MapItem> GetSaleMapItems(IQueryable<OrderItem> orderItems, long productId, Period period = Period.Lifetime)
        //{
        //    return QueriesHelper.GetSaleMapItemsCore(Queryable.Where<OrderItem>(Queryable.Where<OrderItem>(orderItems, QueriesHelper.GetOrderItemsForPeriodFilter(period, new DateTime())), (Expression<Func<OrderItem, bool>>)(x => x.ProductId == (long?)productId)));
        //}

        //public static IEnumerable<MapItem> GetSaleMapItemsByCustomer(IQueryable<OrderItem> orderItems, long customerId, Period period = Period.Lifetime)
        //{
        //    return QueriesHelper.GetSaleMapItemsCore(Queryable.Where<OrderItem>(Queryable.Where<OrderItem>(orderItems, (Expression<Func<OrderItem, bool>>)(x => x.Order.CustomerId == (long?)customerId)), QueriesHelper.GetOrderItemsForPeriodFilter(period, new DateTime())));
        //}

        //public static IEnumerable<MapItem> GetSaleMapItemsByCustomerAndCity(IQueryable<OrderItem> orderItems, long customerId, string city, Period period = Period.Lifetime)
        //{
        //    return QueriesHelper.GetSaleMapItemsByCustomer(Queryable.Where<OrderItem>(orderItems, (Expression<Func<OrderItem, bool>>)(x => x.Order.Store.Address.City == city)), customerId, period);
        //}

        private static IEnumerable<MapItem> GetSaleMapItemsCore(IQueryable<OrderItem> orderItems)
        {
            return (IEnumerable<MapItem>)Queryable.Select<OrderItem, MapItem>(orderItems, (Expression<Func<OrderItem, MapItem>>)(x => new MapItem()
            {
                Customer = x.Order.Customer,
                Product = x.Product,
                Total = x.Total,
                Address = x.Order.Store.Address
            }));
        }

        //public static IEnumerable<SalesSummaryItem> GetSalesSummaryItems(IQueryable<OrderItem> orderItems, Period period, DateTime dateTime = null)
        //{
        //    return (IEnumerable<SalesSummaryItem>)Enumerable.ToList<SalesSummaryItem>((IEnumerable<SalesSummaryItem>)Queryable.Select<IGrouping<ProductCategory, OrderItem>, SalesSummaryItem>(Queryable.GroupBy<OrderItem, ProductCategory>(QueriesHelper.GetOrderItemsForPeriod(orderItems, period, dateTime), (Expression<Func<OrderItem, ProductCategory>>)(oi => oi.Product.Category)), (Expression<Func<IGrouping<ProductCategory, OrderItem>, SalesSummaryItem>>)(g => new SalesSummaryItem()
        //    {
        //        Category = g.Key,
        //        Sales = Enumerable.Sum<OrderItem>(g, (Func<OrderItem, Decimal>)(oi => oi.Total))
        //    })));
        //}

        //public static IEnumerable<CostAverageItem> GetCostAverageItems(IQueryable<OrderItem> orderItems, Period period, DateTime dateTime = null)
        //{
        //    return (IEnumerable<CostAverageItem>)Enumerable.ToList<CostAverageItem>((IEnumerable<CostAverageItem>)Queryable.Select<IGrouping<ProductCategory, OrderItem>, CostAverageItem>(Queryable.GroupBy<OrderItem, ProductCategory>(QueriesHelper.GetOrderItemsForPeriod(orderItems, period, dateTime), (Expression<Func<OrderItem, ProductCategory>>)(oi => oi.Product.Category)), (Expression<Func<IGrouping<ProductCategory, OrderItem>, CostAverageItem>>)(g => new CostAverageItem()
        //    {
        //        Category = g.Key,
        //        Cost = Enumerable.Average<OrderItem>(g, (Func<OrderItem, Decimal>)(oi => oi.ProductPrice))
        //    })));
        //}

        //public static IEnumerable<CustomerStore> GetDistinctStoresForPeriod(IQueryable<Order> orders, long customerId, Period period = Period.Lifetime)
        //{
        //    return (IEnumerable<CustomerStore>)Queryable.Distinct<CustomerStore>(Queryable.Select<IGrouping<CustomerStore, Order>, CustomerStore>(Queryable.GroupBy<Order, CustomerStore>(QueriesHelper.GetCustomerOrdersForPeriod(orders, period, customerId), (Expression<Func<Order, CustomerStore>>)(o => o.Store)), (Expression<Func<IGrouping<CustomerStore, Order>, CustomerStore>>)(g => g.Key)));
        //}

        public static Decimal GetQuotesTotal(IQueryable<Quote> quotes, CustomerStore store, DateTime begin, DateTime end)
        {
            return QueriesHelper.CustomSum<Quote>((IEnumerable<Quote>)Queryable.Where<Quote>(quotes, (Expression<Func<Quote, bool>>)(x => x.CustomerStoreId == (long?)store.Id && x.Date >= begin && x.Date <= end)), (Expression<Func<Quote, Decimal>>)(x => x.Total));
        }

        public static IEnumerable<QuoteSummaryItem> GetSummaryOpportunities(IQueryable<Quote> quotes)
        {
            yield return QueriesHelper.GetSummaryItem(quotes, Stage.High);
            yield return QueriesHelper.GetSummaryItem(quotes, Stage.Medium);
            yield return QueriesHelper.GetSummaryItem(quotes, Stage.Low);
            yield return QueriesHelper.GetSummaryItem(quotes, Stage.Unlikely);
        }

        public static IEnumerable<QuoteMapItem> GetOpportunities(IQueryable<Quote> quotes, IQueryable<Customer> customers, Stage stage)
        {
            Enum.GetName(typeof(Stage), (object)stage);
            return (IEnumerable<QuoteMapItem>)Queryable.Join<Quote, Customer, long?, QuoteMapItem>(QueriesHelper.GetQuotes(quotes, stage), (IEnumerable<Customer>)customers, (Expression<Func<Quote, long?>>)(q => q.CustomerId), (Expression<Func<Customer, long?>>)(c => (long?)c.Id), (Expression<Func<Quote, Customer, QuoteMapItem>>)((q, c) => new QuoteMapItem()
            {
                Stage = stage,
                Address = q.CustomerStore.Address,
                Value = q.Total,
                Date = q.Date
            }));
        }

        public static IEnumerable<QuoteMapItem> GetOpportunities(IQueryable<Quote> quotes)
        {
            yield return QueriesHelper.GetOpportunity(quotes, Stage.High);
            yield return QueriesHelper.GetOpportunity(quotes, Stage.Medium);
            yield return QueriesHelper.GetOpportunity(quotes, Stage.Low);
            yield return QueriesHelper.GetOpportunity(quotes, Stage.Unlikely);
        }

        private static QuoteMapItem GetOpportunity(IQueryable<Quote> quotes, Stage stage)
        {
            QuoteMapItem quoteMapItem = new QuoteMapItem();
            quoteMapItem.Stage = stage;
            quoteMapItem.Value = QueriesHelper.CustomSum<Quote>((IEnumerable<Quote>)QueriesHelper.GetQuotes(quotes, stage), (Expression<Func<Quote, Decimal>>)(q => q.Total));
            return quoteMapItem;
        }

        public static Decimal GetOpportunity(IQueryable<Quote> quotes, Stage stage, string city)
        {
            return QueriesHelper.CustomSum<Quote>((IEnumerable<Quote>)Queryable.Where<Quote>(QueriesHelper.GetQuotes(quotes, stage), (Expression<Func<Quote, bool>>)(q => q.CustomerStore.Address.City == city)), (Expression<Func<Quote, Decimal>>)(q => q.Total));
        }

        public static IEnumerable<CustomerStore> GetCustomerStore(IQueryable<CustomerStore> stores, IQueryable<Quote> quotes, Stage stage)
        {
            return (IEnumerable<CustomerStore>)Queryable.Join<Quote, CustomerStore, long?, CustomerStore>(QueriesHelper.GetQuotes(quotes, stage), (IEnumerable<CustomerStore>)stores, (Expression<Func<Quote, long?>>)(q => q.CustomerStoreId), (Expression<Func<CustomerStore, long?>>)(s => (long?)s.Id), (Expression<Func<Quote, CustomerStore, CustomerStore>>)((q, s) => s));
        }

        private static QuoteSummaryItem GetSummaryItem(IQueryable<Quote> quotes, Stage stage)
        {
            IQueryable<Quote> quotes1 = QueriesHelper.GetQuotes(quotes, stage);
            QuoteSummaryItem quoteSummaryItem1 = new QuoteSummaryItem();
            quoteSummaryItem1.StageName = stage.ToString();
            QuoteSummaryItem quoteSummaryItem2 = quoteSummaryItem1;
            Decimal num;
            if (Queryable.Any<Quote>(quotes1))
                num = QueriesHelper.CustomSum<Quote>((IEnumerable<Quote>)quotes1, (Expression<Func<Quote, Decimal>>)(q => q.Total));
            else
                num = new Decimal(0);
            quoteSummaryItem2.Summary = num;
            return quoteSummaryItem1;
        }

        private static IQueryable<Quote> GetQuotes(IQueryable<Quote> quotes, Stage stage)
        {
            double min;
            double max;
            switch (stage)
            {
                case Stage.High:
                    max = 1.0;
                    min = 0.6;
                    break;
                case Stage.Medium:
                    min = 0.3;
                    max = 0.6;
                    break;
                case Stage.Low:
                    min = 0.12;
                    max = 0.3;
                    break;
                case Stage.Summary:
                    min = 0.0;
                    max = 1.0;
                    break;
                default:
                    min = 0.0;
                    max = 0.12;
                    break;
            }
            return Queryable.Where<Quote>(quotes, (Expression<Func<Quote, bool>>)(q => q.Opportunity > min && q.Opportunity < max));
        }
    }
}

