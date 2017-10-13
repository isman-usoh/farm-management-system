using System;
using System.Collections.Generic;
using System.Linq;

namespace MainProject.Util
{
    internal class TypeUtil
    {
        public static String User = "User";
        public static String Customer = "Customer";
        public static String Company = "Company";
        public static String Gene = "Gene";
        public static String Corral = "Corral";
        public static String Cow = "Cow";
        public static String Recipes = "Recipes";
        public static String OrderOut = "OrderOut";
        public static String OrderIn = "OrderIn";
        public static String DiseaseHistory = "DiseaseHistory";
        public static String DiseaseMedicine = "DiseaseMedicine";
        public static String Vaccine = "Vaccine";
        public static String Stock = "Stock";
        public static String StockAdd = "StockAdd";
        public static String StockAddList = "StockAddList";
        public static String StockRemove = "StockRemove";
        public static String RecipesHistory = "RecipesHistory";
        public static String RecipesListHistory = "RecipesListHistory";
        public static String StockRemoveList = "StockRemoveList";

        public static byte EVENT_CREATE = 0;
        public static byte EVENT_MODIFY = 1;
        public static byte EVENT_REMOVE = 2;
        public static byte EVENT_CHANGE_PASSWORD = 3;
        public static byte EVENT_BUY = 4;
        public static byte EVENT_SELL = 5;
        public static byte EVENT_BORN = 6;
        public static byte EVENT_DEAD = 7;
        public static byte EVENT_STOCK_REMOVE = 8;
        public static byte EVENT_USER_LOGIN = 9;


        public static SortedDictionary<Byte, String> Event()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "สร้าง");
            Dictionary.Add(1, "แก้ไข");
            Dictionary.Add(2, "ลบ");
            Dictionary.Add(3, "เปลี่ยนรหัสผ่าน");
            Dictionary.Add(4, "ซื้อ");
            Dictionary.Add(5, "ขาย");
            Dictionary.Add(6, "เกิด");
            Dictionary.Add(7, "ตาย");
            Dictionary.Add(8, "เบิกพัสดุ");
            Dictionary.Add(9, "ล็อกอิน");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> Prename()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "นางสาว");
            Dictionary.Add(1, "นาง");
            Dictionary.Add(2, "นาย");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> InOrderType()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "ซื้อแยก");
            Dictionary.Add(1, "เหมาซื้อ");
            Dictionary.Add(2, "คลอดลูก");
            Dictionary.Add(3, "ชั่งกิโลซื้อ");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> InOrderTypeWithoutBorn()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "ซื้อแยก");
            Dictionary.Add(1, "เหมาซื้อ");
            Dictionary.Add(3, "ชั่งกิโลซื้อ");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> InTransportType()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "ไปรับเอง");
            Dictionary.Add(1, "ส่งถึงที่");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> InPaymentType()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "เงินสด");
            Dictionary.Add(1, "โอนเงิน");
            Dictionary.Add(2, "เช็ค");
            return Dictionary;
        }
        public static SortedDictionary<Byte, String> InPaymentStatus()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "ยังไม่ได้ชำระเงิน");
            Dictionary.Add(1, "ชำระเงินแล้ว");
            return Dictionary;
        }
        public static SortedDictionary<Byte, String>  OutOrderType()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "ขายแยก");
            Dictionary.Add(1, "เหมาขาย");
            Dictionary.Add(2, "ตาย");
            Dictionary.Add(3, "ชั่งกิโลขาย");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> OutOrderTypeWithoutDead()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "ขายแยก");
            Dictionary.Add(1, "เหมาขาย");
            Dictionary.Add(3, "ชั่งกิโลขาย");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> OutTransportType()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "ไปรับเอง");
            Dictionary.Add(1, "ส่งถึงที่");
            return Dictionary;
        }
        public static SortedDictionary<Byte, String> OutPaymentType()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "เงินสด");
            Dictionary.Add(1, "โอนเงิน");
            Dictionary.Add(2, "เช็ค");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> OutPaymentStatus()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "ยังไม่ได้รับชำระเงิน");
            Dictionary.Add(1, "ชำระเงินแล้ว");
            return Dictionary;
        }
        public static SortedDictionary<Byte, String> CowSex()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "ผู้");
            Dictionary.Add(1, "เมีย");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> AccountType()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "ออมทรัพ");
            Dictionary.Add(1, "กระแสรายวัน");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> StockType()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(1, "อาหาร");
            Dictionary.Add(2, "วัคซีน");
            Dictionary.Add(3, "ยา");
            return Dictionary;
        }

        public static SortedDictionary<Byte, String> StockRevemoFormType()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "เบิกตามปกติ");
            Dictionary.Add(1, "เบิกจากฉีดวัคซีน");
            Dictionary.Add(2, "เบิกจากรักษาโรค");
            Dictionary.Add(3, "เบิกจากสูตรอาหาร");
            Dictionary.Add(4, "เบิกจากการซื้อ");
            return Dictionary;
        }

        public static List<String> Country()
        {
            var List = new List<String>();
            List.Add("ประเทศไทย");
            return List;
        }

        public static SortedDictionary<Byte, String> ResourceFromType()
        {
            var Dictionary = new SortedDictionary<Byte, String>();
            Dictionary.Add(0, "การซื้อ");
            Dictionary.Add(1, "การขาย");
            Dictionary.Add(2, "การเกิด");
            Dictionary.Add(3, "การตาย");
            Dictionary.Add(4, "การเพิ่มพัสดุ");
            Dictionary.Add(5, "การเบิกพัสดุ");
            return Dictionary;
        }

        public static SortedDictionary<String, String> ResourceType()
        {
            var Dictionary = new SortedDictionary<String, String>();
            Dictionary.Add("doc", "application/msword");
            Dictionary.Add("docx", "application/msword");
            Dictionary.Add("pdf", "application/pdf");
            Dictionary.Add("jpeg", "image/jpeg");
            Dictionary.Add("jpg", "image/jpeg");
            Dictionary.Add("png", "image/png");
            return Dictionary;
        }
    }
}
