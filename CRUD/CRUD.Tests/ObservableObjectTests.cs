using CRUD.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Tests
{
    [TestClass]
    public class ObservableObjectTests
    {
        [TestMethod]
        public void PropertyChangedEventHandlerisRaised()
        {
            var obj = new StubObservableObject();

            bool raised = false;

            obj.PropertyChanged += (sender, e) =>
                                {
                                    Assert.IsTrue(e.PropertyName == "ChangedProperty");
                                    raised = true;
                                };

            obj.ChangedProperty = "Some value";

            if (!raised) Assert.Fail("PropertyChanged was never invoked.");

        }

        class StubObservableObject : ObservableObject
        {
            private string _changedProperty;

            public string ChangedProperty
            {
                get { return _changedProperty; }
                set
                {
                    _changedProperty = value;
                    NotifyPropertyChanged();
                }
            }


        }


    }
}
