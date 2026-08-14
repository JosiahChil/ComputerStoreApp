using System;

namespace CompSoftwareMastery
{
    public class DatabaseModel
    {
        //holds all information and variables in the database


        public int LogonID { get; set; }
        public int PersonID { get; set; }
        public string LogonName { get; set; }
        public string Password { get; set; }
        public int FirstChallengeQuestion { get; set; }
        public string FirstChallengeAnswer { get; set; }
        public int SecondChallengeQuestion { get; set; }
        public string SecondChallengeAnswer { get; set; }
        public int ThirdChallengeQuestion { get; set; }
        public string ThirdChallengeAnswer { get; set; }
        public string PositionTitle { get; set; }
        public bool AccountDisabled { get; set; }
        public bool AccountDeleted { get; set; }

        public int DiscountID { get; set; }
        public string DiscountCode { get; set; }
        public string Description { get; set; }
        public int DiscountLevel { get; set; }
        public int InventoryID { get; set; }
        public string DiscountType { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountDollarAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }



        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int CategoryID { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public int RestockThreshold { get; set; }
        public byte[] ItemImage { get; set; }
        public bool Discontinued { get; set; }



        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }



        public int OrderDetailsID { get; set; }
        public int OrderID { get; set; }

        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public string CC_Number { get; set; }
        public DateTime ExpDate { get; set; }
        public string CCV { get; set; }



        public string Title { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NameLast { get; set; }
        public string Suffix { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string PhonePrimary { get; set; }
        public string PhoneSecondary { get; set; }
        public byte[] Image { get; set; }
        public int PositionID { get; set; }
        public bool PersonDeleted { get; set; }

        public int QuestionID { get; set; }
        public int SetID { get; set; }
        public string QuestionPrompt { get; set; }
    }
}











