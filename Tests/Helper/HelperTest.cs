namespace Tests.Helper
{
    public static class HelperTest
    {
        public static bool CheckProperties<TEntity>(TEntity entity)
        {
            var properties = entity.GetType().GetProperties();
            var isEmpty = false;

            foreach (var p in properties)
            {
                var value = p.GetValue(entity);

                if (value is null)
                {
                    isEmpty = true;
                    break;
                }
            }

            return isEmpty;
        }
    }
}
