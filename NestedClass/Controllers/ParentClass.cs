namespace NestedClass.Controllers
{
    public class ParentClass
    {
        public ParentClass()
        {
            ParentName = "My Name is Parent";
        }
        public string ParentName { get; set; }
        public class ChildClass
        {
            public ChildClass()
            {
                ChildName = "My Name is Child";
            }
            public string ChildName { get; set; }
            
        }

        public class AnotherChild
        {
            public AnotherChild()
            {
                AnotherChildName = "My Name is another Child";
            }
            public string AnotherChildName { get; set; }
        }
    }
}