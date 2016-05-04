using System;

namespace TI.ReportPlus.BE
{
    public class CatalogItem
    {
        private Guid _ItemID;
        private Guid _ParentID;
        private string _Name;
        private string _Description;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ItemID"></param>
        /// <param name="ParentID"></param>
        /// <param name="Name"></param>
        /// <param name="Description"></param>
        public CatalogItem(Guid ItemID, Guid ParentID, string Name, string Description)
        {
            this._ItemID = ItemID;
            this._ParentID = ParentID;
            this._Name = Name;
            this._Description = Description;
        }

        public Guid ItemID
        {
            get
            {
                return _ItemID;
            }

            set
            {
                _ItemID = value;
            }
        }

        public Guid ParentID
        {
            get
            {
                return _ParentID;
            }

            set
            {
                _ParentID = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }
    }
}
