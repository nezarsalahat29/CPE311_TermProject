﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPE311_TermProject
{
    [Serializable]
    class SupplyDocuments
    {
        private string warehouseName;
        private string itemName;
        private int itemCode;
        private int itemQuantity;
        private int type;
        DateTime date;
        private string senderUsername;
        private string recieverUsername;
        private int receiverId;

        public SupplyDocuments(int type, string itemName, int itemCode, int itemQuantity, string senderUsername, string warehouseName="", string recieverUsername="", int receiverId=0)
        {
            this.itemName = itemName;
            this.itemCode = itemCode;
            this.itemQuantity = itemQuantity;
            this.senderUsername = senderUsername;
            this.date = DateTime.Now;
            this.type = type;

            if (type == 1 || type == 3)
            {

                this.warehouseName = warehouseName; 
            }
            else
            {
                this.recieverUsername = recieverUsername;
                this.receiverId = receiverId;
            }
            

        }
       public DateTime getDate()
        {
            return date;
        }



    }
   


}
