using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynAllInOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = @"
using System;
namespace RoslynTest
{
        public interface ICalculator
        {
           
            public static int Evaluate(string a,string b);
            public static string Evaluate2(string a1,string b1);
        }
}";
            string path = @"E:\268VSvn\trunk\04_Code\0404_Checking\netWebServices\Testing\WebApplication1\CheckReport.asmx.cs";
            text = File.ReadAllText(path);
            SyntaxTree tree = Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(text);
            var root = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)tree.GetRoot();
            var nameSpaceCollection= root.DescendantNodes().OfType<NamespaceDeclarationSyntax>();

            foreach (var nameSpace in nameSpaceCollection)
            {
                foreach (var member in nameSpace.Members)
                {
                    var node= (SyntaxNode) member;
                    if (node != null)
                    {
                        var classTemp = node as ClassDeclarationSyntax;
                        var classMembers = classTemp.Members;
                        foreach (var classMember in classMembers)
                        {
                            if (classMember.Kind() == SyntaxKind.FieldDeclaration)
                            {
                                
                            }
                            if (classMember.Kind() == SyntaxKind.MethodDeclaration)
                            {
                                var method = classMember as MethodDeclarationSyntax;
                                if (method != null)
                                {
                                    foreach (var parameter in method.ParameterList.Parameters)
                                    {
                                        //方法参数类型 方法参数名字
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            
            var firstMember = root.Members[0];
            
            NamespaceDeclarationSyntax nameSpaceDeclaration = (NamespaceDeclarationSyntax)firstMember;

            var classDeclarationSyntax= (ClassDeclarationSyntax) nameSpaceDeclaration.Members[0];


            InterfaceDeclarationSyntax interfaceDeclaration = (InterfaceDeclarationSyntax)nameSpaceDeclaration.Members[0];
            Console.WriteLine("命名空间:" + nameSpaceDeclaration.Name);
            Console.WriteLine("接口名:" + interfaceDeclaration.Identifier.Value);


            IEnumerable<SyntaxAnnotation> ss = interfaceDeclaration.GetAnnotations("ICalculator");
            ss.ToList().ForEach(x =>
            {
                Console.WriteLine("接口描述:" + x.Data);
            });

            interfaceDeclaration.Members.ToList().ForEach(y =>
            {

                MethodDeclarationSyntax methodDeclaration = (MethodDeclarationSyntax)y;
                var paramsDeclaration = methodDeclaration.ParameterList.Parameters;

                Console.WriteLine("返回类型:" + methodDeclaration.ReturnType + "方法名称:" + methodDeclaration.Identifier);
                paramsDeclaration.ToList().ForEach(x =>
                {

                    Console.WriteLine("参数类型:" + x.Type + ",参数名称:" + x.Identifier);
                });
            });



            Console.ReadKey();
        }
    }
}
