namespace LivePush
{
    class Data
    {
        public static string Code(string path)
        {
            string Code = "";
            Code += "@echo on\n";
            Code += ("cd " + path).Remove(("cd " + path).Length - 11);
            Code += "\ngit add -A\ngit commit -m \"some commit\"\ngit push origin master";
            return Code;
        }
    }
}
