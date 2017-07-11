using System;
using System.Activities;

namespace AbstractActivityForUiPath
{
    public abstract class AbstractActivity : CodeActivity
    {
        public string MyStringProperty { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            throw new NotImplementedException();
        }
    }
}
