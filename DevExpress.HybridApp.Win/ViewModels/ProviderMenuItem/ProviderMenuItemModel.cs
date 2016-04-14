using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel;
using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV;

namespace DevExpress.DevAV.ViewModels
{
    public partial class ProviderMenuItemModel : SingleObjectViewModel<ProviderMenuItem, int, IDevAVDbUnitOfWork>
    {

        /// <summary>
        /// Initializes a new instance of the ProductViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProductViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProviderMenuItemModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory, x => x.ProviderMenuItems, x => x.Name) {
        }
        public ProviderMenuItemModel()
            : this(DbUnitOfWorkFactory.Instance) {
        }

        /// <summary>
        /// The look-up collection of Teams for the corresponding navigation property in the view.
        /// </summary>
        public IList<Employee> LookUpEmployees
        {
            get { return GetLookUpEntities(x => x.Employees); }
        }


        protected override void RefreshLookUpCollections(int key)
        {
            //ProductCatalogLookUp = CreateLookUpCollectionViewModel(x => x.ProductCatalogs, x => x.ProductId, (x, m) => x.Product = m, key);
            //ProductOrderItemsLookUp = CreateLookUpCollectionViewModel(x => x.OrderItems, x => x.ProductId, (x, m) => x.Product = m, key);
            //ProductImagesLookUp = CreateLookUpCollectionViewModel(x => x.ProductImages, x => x.ProductId, (x, m) => x.Product = m, key);
        }

        /// <summary>
        /// The view model for the ProductCatalog detail collection.
        /// </summary>
        public virtual CollectionViewModel<ProductCatalog, long, IDevAVDbUnitOfWork> ProductCatalogLookUp { get; set; }

        /// <summary>
        /// The view model for the ProductOrderItems detail collection.
        /// </summary>
        public virtual CollectionViewModel<OrderItem, long, IDevAVDbUnitOfWork> ProductOrderItemsLookUp { get; set; }

        /// <summary>
        /// The view model for the ProductImages detail collection.
        /// </summary>
        public virtual CollectionViewModel<ProductImage, long, IDevAVDbUnitOfWork> ProductImagesLookUp { get; set; }
    }
}
