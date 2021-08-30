using System;
using System.Collections.Generic;
using DaanV2.Processors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Processors {
    public class ProcessClass :
        IProcessor<String>, IPreProcessor<String>, IPostProcessor<String>,
        IProcessor<String, Int32>, IPreProcessor<String, Int32>, IPostProcessor<String, Int32> {

        public void Postprocess(String Process) { }
        public void Postprocess(String Process, Int32 Context) { }
        public void Preprocess(String Process) { }
        public void Preprocess(String Process, Int32 Context) { }
        public void Process(String Process) { }
        public void Process(String Process, Int32 Context) { }
    }

    [TestClass]
    public partial class ProcessorExtensionTest {
        [TestMethod]
        public void TestExtension() {
            String[] P = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui.".Split(' ');
            List<String> LP = new List<String>(P);
            LinkedList<String> LLP = new LinkedList<String>(P);

            ProcessClass PC = new ProcessClass();
            PC.Postprocess(P);
            PC.Postprocess(LP);
            PC.Postprocess(LLP);
            PC.Preprocess(P);
            PC.Preprocess(LP);
            PC.Preprocess(LLP);
            PC.Process(P);
            PC.Process(LP);
            PC.Process(LLP);
        }
    }
}
