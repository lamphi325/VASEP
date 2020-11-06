using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContentItemsMetaData
    {
        public int ContentItemMetaDataId { get; set; }
        public int ContentItemId { get; set; }
        public int MetaDataId { get; set; }
        public string MetaDataValue { get; set; }

        public ContentItems ContentItem { get; set; }
        public MetaData MetaData { get; set; }
    }
}
