﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ClassLibrary1
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PersonalisationFeature : Xunit.IClassFixture<PersonalisationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Personalisation.feature"
#line hidden
        
        public PersonalisationFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Personalisation", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(PersonalisationFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Personalisation")]
        [Xunit.TraitAttribute("Description", "xDB Panel_UC1_no information for visitor")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void XDBPanel_UC1_NoInformationForVisitor()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("xDB Panel_UC1_no information for visitor", new string[] {
                        "NeedImplementation"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("User has opened Legal website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("User has opened xDB info panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("User selects Onsite Behavior section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table1.AddRow(new string[] {
                        "You have not been profiled yet"});
#line 11
 testRunner.Then("<Profiling> contains following values", ((string)(null)), table1, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table2.AddRow(new string[] {
                        "You have triggered no goals so far"});
#line 14
 testRunner.And("<Triggered goals> contains following values", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table3.AddRow(new string[] {
                        "You have reached no outcomes"});
#line 17
 testRunner.And("<Outcomes> contains following values", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Personalisation")]
        [Xunit.TraitAttribute("Description", "xDB Panel_UC2_associated persona for Corporate Finance page")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void XDBPanel_UC2_AssociatedPersonaForCorporateFinancePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("xDB Panel_UC2_associated persona for Corporate Finance page", new string[] {
                        "NeedImplementation"});
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("User has opened Legal website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.And("User has opened Corporate Finance page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("User has opened xDB info panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("User selects Onsite Behavior section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "field values"});
            table4.AddRow(new string[] {
                        "Legal Persona"});
            table4.AddRow(new string[] {
                        "Susan the CEO"});
            table4.AddRow(new string[] {
                        "Eric the Entrepreneur"});
            table4.AddRow(new string[] {
                        "Margaret the Mother"});
            table4.AddRow(new string[] {
                        "Lucas the Lawyer"});
#line 27
 testRunner.Then("<Profiling> contains following values", ((string)(null)), table4, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table5.AddRow(new string[] {
                        "You have triggered no goals so far"});
#line 34
 testRunner.And("<Triggered goals> contains following values", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table6.AddRow(new string[] {
                        "You have reached no outcomes"});
#line 37
 testRunner.And("<Outcomes> contains following values", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "field values"});
            table7.AddRow(new string[] {
                        "Legal Persona"});
            table7.AddRow(new string[] {
                        "Susan the CEO"});
            table7.AddRow(new string[] {
                        "Eric the Entrepreneur"});
            table7.AddRow(new string[] {
                        "Margaret the Mother"});
            table7.AddRow(new string[] {
                        "Lucas the Lawyer"});
#line 40
 testRunner.And("on Home page <Profiling> contains following values", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table8.AddRow(new string[] {
                        "You have triggered no goals so far"});
#line 47
 testRunner.And("<Triggered goals> contains following values", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table9.AddRow(new string[] {
                        "You have reached no outcomes"});
#line 50
 testRunner.And("<Outcomes> contains following values", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Personalisation")]
        [Xunit.TraitAttribute("Description", "xDB Panel_UC3_associated persona for Trust, Estate, and Tax Law page")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void XDBPanel_UC3_AssociatedPersonaForTrustEstateAndTaxLawPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("xDB Panel_UC3_associated persona for Trust, Estate, and Tax Law page", new string[] {
                        "NeedImplementation"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
 testRunner.Given("User has opened Legal website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.And("User has opened Trust, Estate, and Tax Law page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("User has opened xDB info panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.When("User selects Onsite Behavior section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "field name"});
            table10.AddRow(new string[] {
                        "Legal Persona"});
            table10.AddRow(new string[] {
                        "Margaret the Mother"});
            table10.AddRow(new string[] {
                        "Eric the Entrepreneur"});
            table10.AddRow(new string[] {
                        "Susan the CEO"});
            table10.AddRow(new string[] {
                        "Lucas the Lawyer"});
#line 60
 testRunner.Then("<Profiling> contains following values", ((string)(null)), table10, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table11.AddRow(new string[] {
                        "You have triggered no goals so far"});
#line 67
 testRunner.And("<Triggered goals> contains following values", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table12.AddRow(new string[] {
                        "You have reached no outcomes"});
#line 70
 testRunner.And("<Outcomes> contains following values", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "field name"});
            table13.AddRow(new string[] {
                        "Legal Persona"});
            table13.AddRow(new string[] {
                        "Margaret the Mother"});
            table13.AddRow(new string[] {
                        "Eric the Entrepreneur"});
            table13.AddRow(new string[] {
                        "Susan the CEO"});
            table13.AddRow(new string[] {
                        "Lucas the Lawyer"});
#line 73
 testRunner.And("on Home page <Profiling> contains following values", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table14.AddRow(new string[] {
                        "You have triggered no goals so far"});
#line 80
 testRunner.And("<Triggered goals> contains following values", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "field value"});
            table15.AddRow(new string[] {
                        "You have reached no outcomes"});
#line 83
 testRunner.And("<Outcomes> contains following values", ((string)(null)), table15, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PersonalisationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PersonalisationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
