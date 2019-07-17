using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272Homework7_u18001859.Models
{
    public class ShopItemViewModel
    {
        string mName;
        string mDescription;
        double mPrice;
        int mQuantityAvailable;

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }

        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public int QuantityAvailable
        {
            get
            {
                return mQuantityAvailable;
            }
            set
            {
                mQuantityAvailable = value;
            }
        }

        public ShopItemViewModel()
        {

        }

        public ShopItemViewModel(string n, string d, double p, int qa)
        {
            mName = n;
            mDescription = d;
            mPrice = p;
            mQuantityAvailable = qa;
        }
    }
}