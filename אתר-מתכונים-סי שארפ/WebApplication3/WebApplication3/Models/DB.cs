using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication3.Models
{
    public class DB
    {
        public static List<User> userList { get; set; }
        public static List<Category> categoryList { get; set; }
        public static List<Recipe> recipeList { get; set; }
        static DB()
        {
            userList = new List<User>() {
            new User() { code = 12, name = "yaeli", address = "geula", mail = "12@gmail.com", password = "12" },
            new User() { code = 34, name = "rivka", address = "geula", mail = "34@gmail.com", password = "34" },
            new User() { code = 56, name = "yaeli", address = "geula", mail = "56@gmail.com", password = "56" },
            new User() { code = 78, name = "yaeli", address = "geula", mail = "78@gmail.com", password = "78" }
            };
            categoryList = new List<Category>()
            {
            new Category() { name = "עוגות",code = 11,routing = "C:/Users/Sara/Desktop/angular/projectall/projct3/src/assets.1"},
            new Category() { name = "קינוחים",code = 22,routing = "C:/Users/Sara/Desktop/angular/projectall/projct3/src/assets.2"},
            new Category() { name = "פירות",code = 33 ,routing = "C:/Users/Sara/Desktop/angular/projectall/projct3/src/assets.3"},
            };


            recipeList = new List<Recipe>()
            {
                //מתכונים לעוגות

                new Recipe (){codeRecipe=0,
                    nameRecipe="עוגת גבינה וקפה",
                    codeCategory=11,
                    timeAtMinute=10,
                    LevelDifficulty=1,
                    addRecipe=DateTime.Now,
                    ingredients="שתי ביצים גדולות-חצי כוס שמן-שליש כוס סוכר-שקית סוכר וניל- שלושת רבעי כוס נס קפה מוכן- כוס וחצי קמח לבן מעורבב עם כפית אבקת אפיה-כפית שטוחה אבקת קקאו",
                    Preparation="מחממים תנו ל 180 מעלות ומשמנים תבנית.-מערבבים את כל החומרים במיקסר עד לקבלת תערובת אחידה-יוצקים לתבנית משומנת ומכניסים לתנור החם-אופים במשך 20 דקות עד שקיסם יוצא יבש",
                    userCode=12 ,
                    image="https://www.10dakot.co.il/wp-content/uploads/2020/05/%E2%80%8F%E2%80%8FDSC_0032-%D7%A2%D7%95%D7%AA%D7%A7.jpg",
                    isShow=true
                },

                new Recipe (){codeRecipe=1,
                    nameRecipe="עוגת פנקייק",
                    codeCategory=11,
                    timeAtMinute=12,
                    LevelDifficulty=1,
                    addRecipe=DateTime.Now,
                    ingredients="שתי כוסות קמח לבן- שקית סוכר וניל- שתי כפות סוכר- שת ביצים- שלוש כפות שמן- שת כוסות חלב- ממרח שוקולד שאוהבים",
                    Preparation="מערבבים את כל החומרים בקערה עד לקבלת בלילה חלקה- מחממים מחבת ם מעט שמן- כשהמחבת חמה יוצקים לתוכה רבע מכמות הבלילה- מכסים את המכבת ומשאירים על אש נמוכה כמה דקות-הופכים את הפנקייק וממתינים שוב כמ דקות-מגישים בערמה עם ממרח אהוב",
                    userCode=12 ,
                    image="https://www.10dakot.co.il/wp-content/uploads/2020/09/%E2%80%8F%E2%80%8FDSC_0252-%D7%A2%D7%95%D7%AA%D7%A7.jpg",
                    isShow=true
                },

                new Recipe (){codeRecipe=2,
                    nameRecipe="מאפינס חלב",
                    codeCategory=11,
                    timeAtMinute=12,
                    LevelDifficulty=1,
                    addRecipe=DateTime.Now,
                    ingredients="שתי ביצים קטנות-שליש כוס סוכר-שקית סוכר וניל-שליש כוס שמן-חצי כוס חלב+כפית מיץ לימון-כוס קמח תופח-חמישים גרם שוקולד לבן-חמישים גרם שוקולד חלב",
                    Preparation="מחממים תנור ל180 מעלות- משמנים תבניות מאפינס אישיות-מערבבים את כל החומרים לפי הסדר מלבד השוקולד-יוצקים לתבניות ומפזרים מעל את השוקולד הקצוץ-אופים עד שקיסם יוצא יבש",
                    userCode=12 ,
                    image="https://www.10dakot.co.il/wp-content/uploads/2020/05/%E2%80%8F%E2%80%8FDSC_0034-%D7%A2%D7%95%D7%AA%D7%A7.jpg",
                    isShow=true
                },

                //קינוחים
                new Recipe (){codeRecipe=3,
                    nameRecipe="חטיפי יוגורט ",
                    codeCategory=22,
                    timeAtMinute=11,
                    LevelDifficulty=1,
                    addRecipe=DateTime.Now,
                    ingredients="ארבע מאות חמישים גרם יוגורט בטעם טבעי-שלוש כפות סירופ מייפלחצי כפית תמצית וניל-חצי כוס תותים-שוקולדים אהובים-ועוד תוספות כרצונכם",
                    Preparation="מערבבים בקערה את היוגורט עם מייפל/דבש ותמצית הוניל-מפזרים מעל חתיכות תותים ושוקולד קצוץ .-מכסים את התבנית ומכניסים למקפיא במשך 5-6 שעות לפחות, עד שזה קופא לגמרי.-מחלצים מהתבנית, מסירים את נייר האפיה ושוברים לחתיכות.-שומרים בקופסה סגורה במקפיא.-רעיונות לתוספות נוספות:  אגוזי פקאן מסוכרים, שברי עוגיות/ אוראו, פטל, אננס, מנגו.",
                    userCode=12 ,
                    image="https://www.10dakot.co.il/wp-content/uploads/2020/07/%E2%80%8F%E2%80%8FDSC_00099-%D7%A2%D7%95%D7%AA%D7%A7.jpg",
                    isShow=true
                },

                new Recipe (){codeRecipe=4,
                    nameRecipe="מוס שוקולד",
                    codeCategory=22,
                    timeAtMinute=11,
                    LevelDifficulty=1,
                    addRecipe=DateTime.Now,
                    ingredients="פחית קרם קוקוס-כף סוכר- מאה גרם שוקולד מריר-שתי כפות פודינג שוקולד או וניל",
                    Preparation="מוציאים את פחית הקוקוס מהמקרר ופותחים את הפחית.-לאחר לילה במקרר תיווצר הפרדה בין החלק השומני-הקרמי לבין החלק הנוזלי.-שופכים בעדינות לתוך כוס כמות של שליש כוס מהנוזלים ושומרים בצד. -שוברים את השוקולד לקוביות ומניחים בקערית נפרדת עם 5 כפות מנוזל הקוקוס ששמרנו בצד.-מכניסים מיקרוגל וממיסים במשך 10-15 שניות. מערבבים עד לתערובת חלקה-לקרם הקוקוס שבקערה מוסיפים כף סוכר וכף אינסטנט פודינג ומקציפים בעזרת מיקסר במשך כחצי דקה.- מוסיפים את תערובת השוקולד וממשיכים להקציף עד לקבלת קרם יציב.-בעזרת שקית זילוף מעבירים את התערובת לכוסות הגשה. ניתן להגיש מיד או לשמור במקרר",
                    userCode=12 ,
                    image="https://www.10dakot.co.il/wp-content/uploads/2020/03/%E2%80%8F%E2%80%8FDSC_0056-%D7%A2%D7%95%D7%AA%D7%A7.jpg",
                    isShow=true
                },
                new Recipe (){codeRecipe=5,
                    nameRecipe="קינוח קדאיף ",
                    codeCategory=22,
                    timeAtMinute=20,
                    LevelDifficulty=1,
                    addRecipe=DateTime.Now,
                    ingredients="מאה גרם איטריות קדאיף-חמישים גרם חמאה מומסת-מיכל שמנת מתוקה-רבע כוס אבקת סוכר-שלוש כות פודנג וניל-פרות יער קפואים לקישוט",
                    Preparation="מערבבים את שערות הקדאיף עם החמאה ומפרידים את השערות תוך כדי בעזרת האצבעות.-מניחים בתחתית תבנית מאפינס ומהדקים-מקציפים במיקסר את השמנת עם אבקת הסוכר במשך כחצי דקה. -מוסיפים פודינג וניל ומקציפים עד לקבלת קצפת יציבה. -מוסיפים גבינה לבנה ומערבבים בעזרת כף בתנועות קיפול עד לאיחוד החומרים.-מוציאים את תחתיות הקדאיף מהתבנית ומניחים בצלחת. יוצקים כף מסירופ הסוכר מעל כל תחתית.-שמים את קרם הגבינה בשקית זילוף (או שקית אוכל שגזרנו לה את הקצה) ומזלפים את הקרם.-שומרים בקופסה סגורה במקרר. לפני ההגשה מומלץ להוסיף פירות יער קפואים.",
                    userCode=12 ,
                    image="https://www.10dakot.co.il/wp-content/uploads/2019/10/%E2%80%8F%E2%80%8FDSC_0031-%D7%A2%D7%95%D7%AA%D7%A7.jpg",
                    isShow=true
                },
                new Recipe (){codeRecipe=6,
                    nameRecipe="פרוזן יוגורט",
                    codeCategory=22,
                    timeAtMinute=11,
                    LevelDifficulty=1,
                    addRecipe=DateTime.Now,
                    ingredients="מאתיים מל יודורט במתיקות מעודנת-שלוש בננות גדולות קלופות קפואות-שלוש תותים קפואים-שלוש כפות סירופ מייל או דבש-שליש כוס פקאן מסוכר-שוקולדים אהובים",
                    Preparation="מניחים את כל המרכיבים במעבד מזון-טוחנים לבלילה חלקה-מקפיאים מעט-יש להכין סמוך להגשה",
                    userCode=12 ,
                    image="https://www.10dakot.co.il/wp-content/uploads/2017/09/%E2%80%8F%E2%80%8F%E2%80%8F%E2%80%8FDSC_0020-%D7%A2%D7%95%D7%AA%D7%A7-%D7%A2%D7%95%D7%AA%D7%A7-2.jpg",
                    isShow=true
                },

                //פרות
                new Recipe (){codeRecipe=7,
                    nameRecipe="שייק פירות",
                    codeCategory=22,
                    timeAtMinute=11,
                    LevelDifficulty=1,
                    addRecipe=DateTime.Now,
                    ingredients="פירות קפואים קלופים כמו בננות, תותים, מלון, מנגו, אבטיח, אפרסקים, שזיפים, נקטרינות ועוד-חלב או מיץ תפוזים-חלב מעניק מרקם עשיר וכבד יותר. עם מיץ תפוזים תקבלו שייק יותר קליל, פירותי ואוורירי.",
                    Preparation="שמים את הפירות בבלנדר,-מוסיפים חלב או מיץ תפוזים בהדרגה ולפי המרקם הרצוי -טוחנים למחית אחידה.-טועמים וממתיקים לפי הצורך ,לא תמיד צריך להמתיק",
                    userCode=12 ,
                    image="https://www.10dakot.co.il/wp-content/uploads/2017/08/%E2%80%8F%E2%80%8F%D7%A9%D7%99%D7%99%D7%A7-%D7%A4%D7%99%D7%A8%D7%95%D7%AA-%D7%A2%D7%95%D7%AA%D7%A7.jpg",
                    isShow=true
                },




















                new Recipe (){codeRecipe=8,
                    nameRecipe="עוגת גבינה",
                    codeCategory=11,
                    timeAtMinute=15,
                    LevelDifficulty=1,
                    addRecipe=DateTime.Now,
                    ingredients="שוקולד -גבינה -קמח -סוכר -אבקת אפיה",
                    Preparation="לערבב את כל החומרים לפי הסדר-לחמם תנור למאה שמונים מעלות-לאפות עשרים דקות -להגיש קר",
                    userCode=12 ,
                    image="https://www.10dakot.co.il/wp-content/uploads/2019/07/DSC_0041-%D7%A2%D7%95%D7%AA%D7%A7-800x532-2-785x522.jpg",
                    isShow=true
                },

                };


        }



        // = new List<Recipe>() {
        //    new Recipe(){codeRecipe="14",codeCategory="cake",nameRecipe="שמנת",addRecipe=DateTime.Now,LevelDifficulty=1,timeAtMinute=10,userCode="12",isShow=true,image="", ingredients={ "2 ביצים M","חצי כוס (100 ג') סוכר" ,"חצי כפית גרידת קליפת לימון","חצי כוס שמן","מיכל שמנת חמוצה" },
        //        Preparation = {"-מחממים תנור ל-180 מעלות ומשמנים תבנית אינגליש קייק.","מערבבים את כל החומרים בעזרת מטרפה ידנית או מיקסר לפי הסדר שהם רשומים, עד לקבלת תערובת אחידה."} },
        //    new Recipe(){codeRecipe="14",codeCategory="cake",nameRecipe="שמנת",addRecipe=DateTime.Now,LevelDifficulty=1,timeAtMinute=10,userCode="12",isShow=true,image="", ingredients={ "2 ביצים M","חצי כוס (100 ג') סוכר" ,"חצי כפית גרידת קליפת לימון","חצי כוס שמן","מיכל שמנת חמוצה" },
        //        Preparation = {"-מחממים תנור ל-180 מעלות ומשמנים תבנית אינגליש קייק.","מערבבים את כל החומרים בעזרת מטרפה ידנית או מיקסר לפי הסדר שהם רשומים, עד לקבלת תערובת אחידה."} },
        //    new Recipe(){codeRecipe="14",codeCategory="cake",nameRecipe="שמנת",addRecipe=DateTime.Now,LevelDifficulty=1,timeAtMinute=10,userCode="12",isShow=true,image="", ingredients={ "2 ביצים M","חצי כוס (100 ג') סוכר" ,"חצי כפית גרידת קליפת לימון","חצי כוס שמן","מיכל שמנת חמוצה" },
        //        Preparation = {"-מחממים תנור ל-180 מעלות ומשמנים תבנית אינגליש קייק.","מערבבים את כל החומרים בעזרת מטרפה ידנית או מיקסר לפי הסדר שהם רשומים, עד לקבלת תערובת אחידה."} },
        //};



        }
}
