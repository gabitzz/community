namespace DevExpress.DevAV
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    public class ProductCatalog : DatabaseObject
    {
        private Stream _pdfStream;

        public byte[] PDF { get; set; }

        public Stream PdfStream
        {
            get
            {
                if (this._pdfStream == null)
                {
                    this._pdfStream = new MemoryStream(this.PDF);
                }
                return this._pdfStream;
            }
        }

        public virtual DevExpress.DevAV.Product Product { get; set; }

        public long? ProductId { get; set; }
    }
}

