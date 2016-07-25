using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.BLL
{
    class ObjectManager
    {
        private ObjectManager()
        { 
        }
        public static  ObjectManager DefaultObjectManager
        {
            get{
                if (_defaultObjectManager == null)
                {
                    _defaultObjectManager = new ObjectManager();
                
		        }
                return _defaultObjectManager;
            }

           
        }
        private static ObjectManager _defaultObjectManager = null;

        /// <summary>
        /// get a BLL product object
        /// </summary>
        /// <returns></returns>
        public  ERP.BLL.Product BLLProduct
        {
            get
            {
                if (_bllProduct == null)
                {
                    _bllProduct = new ERP.BLL.Product();
                }
                return _bllProduct;
            }

        }
        private ERP.BLL.Product _bllProduct;

        /// <summary>
        /// get a BLL Statistics object
        /// </summary>
        /// <returns></returns>
        public ERP.BLL.Statistics BLLStatistics
        {
            get
            {
                if (_BLLStatistics == null)
                {
                    _BLLStatistics = new ERP.BLL.Statistics();
                }
                return _BLLStatistics;
            }

        }
        private ERP.BLL.Statistics _BLLStatistics;


    }
}
