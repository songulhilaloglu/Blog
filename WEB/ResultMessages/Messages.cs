namespace WEB.ResultMessages
{
    public static class Messages
    {
        public static class Blog
        {
            public static string Add(string blogTitle)
            {
                return $"{blogTitle} blogu eklenmiştir.";
            }
            public static string Update(string blogTitle)
            {
                return $"{blogTitle} blogu güncellenmiştir.";
            }
            public static string Delete(string blogTitle)
            {
                return $"{blogTitle} blogu silinmiştir.";
            }
            public static string UndoDelete(string blogTitle)
            {
                return $"{blogTitle} blogu geri alınmıştır.";
            }
        }
        public static class Category
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} kategorisi eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} kategorisi güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} kategorisi silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} kategorisi geri alınmıştır.";
            }
        }

        public static class About
        {
            public static string Add(string blogTitle)
            {
                return $"{blogTitle} hakkımızda eklenmiştir.";
            }
            public static string Update(string blogTitle)
            {
                return $"{blogTitle} hakkımızda güncellenmiştir.";
            }
            public static string Delete(string blogTitle)
            {
                return $"{blogTitle} hakkımızda silinmiştir.";
            }
            public static string UndoDelete(string blogTitle)
            {
                return $"{blogTitle} hakkımızda geri alınmıştır.";
            }
        }
        public static class Banner
        {
            public static string Add(string blogTitle)
            {
                return $"{blogTitle} banner eklenmiştir.";
            }
            public static string Update(string blogTitle)
            {
                return $"{blogTitle} banner güncellenmiştir.";
            }
            public static string Delete(string blogTitle)
            {
                return $"{blogTitle} banner silinmiştir.";
            }
            public static string UndoDelete(string blogTitle)
            {
                return $"{blogTitle} banner geri alınmıştır.";
            }
        }

        public static class User
        {
            public static string Add(string userName)
            {
                return $"{userName} email adresli kullanıcı eklenmiştir.";
            }
            public static string Update(string userName)
            {
                return $"{userName} email adresli kullanıcı güncellenmiştir.";
            }
            public static string Delete(string userName)
            {
                return $"{userName} email adresli kullanıcı silinmiştir.";
            }
        }
    }
}
