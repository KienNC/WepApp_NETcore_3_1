using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Enums
{
    public enum enumStatus
    {
        InActive,
        Active
    }
    public enum enumOrderStatus
    {
        InProgress,
        Confirmed,
        Shipping,
        Success,
        Canceled
    }

    public enum enumTransactionStatus
    {
        Success,
        Failed
    }
}
