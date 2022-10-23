namespace Api_Web.Helper
{
    public static class Mep
    {
        public static T meep<T, U>(U values) where T : new()
            where U : class
        {
            T result = new();
            var protect = values.GetType().GetProperties();
            foreach(var prop in protect)
            {
                var pro = prop.GetValue(values);
                var repons = result.GetType().GetProperty(prop.Name);
                if(repons != null) repons.SetValue(result, pro, null);
            }
            return result;
        }
        
    }

}
