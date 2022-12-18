namespace UserList.Utils
{
    public static class Validators
    {
        public static bool IsNull(this object obj)
        {
            if (obj == null) return true;

            return false;
        }
    }
}