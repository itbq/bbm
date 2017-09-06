using Nop.Core.Domain.Customers;
using System;

namespace Nop.Core.Domain.Media
{
    /// <summary>
    /// Represents a download
    /// </summary>
    public partial class Download : BaseEntity
    {
        /// <summary>
        /// Gets a sets a GUID
        /// </summary>
        public virtual Guid DownloadGuid { get; set; }

        /// <summary>
        /// Gets a sets a value indicating whether DownloadUrl property should be used
        /// </summary>
        public virtual bool UseDownloadUrl { get; set; }

        /// <summary>
        /// Gets a sets a download URL
        /// </summary>
        public virtual string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the download binary
        /// </summary>
        public virtual byte[] DownloadBinary { get; set; }

        /// <summary>
        /// The mime-type of the download
        /// </summary>
        public virtual string ContentType { get; set; }

        /// <summary>
        /// The filename of the download
        /// </summary>
        public virtual string Filename { get; set; }

        /// <summary>
        /// Gets or sets the extension
        /// </summary>
        public virtual string Extension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the download is new
        /// </summary>
        public virtual bool IsNew { get; set; }

        /// <summary>
        /// Gets or sets Customer that owns this download
        /// </summary>
        public virtual CompanyInformation Company { get; set; }

        /// <summary>
        /// Get or set customer Id
        /// </summary>
        public virtual int? CompanyId { get; set; }

        /// <summary>
        /// Indicates is current document is legal information document
        /// </summary>
        public bool IsLegal { get; set; }

        /// <summary>
        /// Gets or sets file size 
        /// </summary>
        public long FileSize { get; set; }
    }

}
