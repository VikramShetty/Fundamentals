using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IteratorAndComposite;

namespace FundamentalsTests
{
  [TestClass]
  public class DiversityIntelligenceTests
  {
    [TestMethod]
    public void Name_of_DataNode()
    {
      DataNode dn = new DataNode("Male");
      Assert.AreEqual("\nMale", dn.Print());
    }

    [TestMethod]
    public void TwoLevel_Name_of_DataNode()
    {
      DataNode dnMale = new DataNode("Male");
      DataNode dnHire = new DataNode("Hire");
      dnMale.Add(dnHire);
      Assert.AreEqual("\nMale\nHire", dnMale.Print());
    }

    [TestMethod]
    public void Name_of_DataPoint()
    {
      DataPoint dp = new DataPoint("Applied", "M_H_A_A");
      Assert.AreEqual("\n--Applied, M_H_A_A", dp.Print());
    }

    [TestMethod]
    public void ThreeLevel_of_DataComponent()
    {
      DataComponent dcMale = new DataNode("Male");
      DataComponent dcHire = new DataNode("Hire");
      DataComponent dcAll = new DataNode("All");
      DataPoint dp = new DataPoint("Applied", "M_H_A_A");
      dcMale.Add(dcHire);
      dcHire.Add(dcAll);
      dcAll.Add(dp);
      Assert.AreEqual("\nMale\nHire\nAll\n--Applied, M_H_A_A", dcMale.Print());
    }

    [TestMethod]
    public void MultiLevel_of_DataComponent()
    {
      DataComponent dcMale = new DataNode("Male");
      DataComponent dcHire = new DataNode("Hire");
      DataComponent dcAll = new DataNode("All");
      DataPoint dp = new DataPoint("Applied", "M_H_A_A");
      dcMale.Add(dcHire);
      dcHire.Add(dcAll);
      dcAll.Add(dp);

      DataComponent dcSM = new DataNode("SM");
      DataPoint dp1 = new DataPoint("Applied", "M_H_SM_A");
      dcSM.Add(dp1);
      dcHire.Add(dcSM);

      Assert.AreEqual("\nMale\nHire\nAll\n--Applied, M_H_A_A\nSM\n--Applied, M_H_SM_A",
        dcMale.Print());
    }

    [TestMethod]
    public void MultiLevel_ChangeOrder_DataComponent()
    {
      DataComponent dcMale = new DataNode("Male");
      DataComponent dcHire = new DataNode("Hire");
      dcMale.Add(dcHire);

      DataComponent dcSM = new DataNode("SM");
      DataPoint dp1 = new DataPoint("Applied", "M_H_SM_A");
      dcSM.Add(dp1);
      dcHire.Add(dcSM);

      DataComponent dcAll = new DataNode("All");
      DataPoint dp = new DataPoint("Applied", "M_H_A_A");
      dcHire.Add(dcAll);
      dcAll.Add(dp);

      Assert.AreEqual("\nMale\nHire\nSM\n--Applied, M_H_SM_A\nAll\n--Applied, M_H_A_A",
        dcMale.Print());
    }

    [TestMethod]
    public void MultiLevel_TwoDepth_of_DataComponent()
    {
      DataComponent dcMale = new DataNode("Male");
      DataComponent dcHire = new DataNode("Hire");
      DataComponent dcAll = new DataNode("All");
      DataPoint dp = new DataPoint("Applied", "M_H_A_A");
      dcMale.Add(dcHire);
      dcHire.Add(dcAll);
      dcAll.Add(dp);

      DataComponent dcSM = new DataNode("SM");
      DataPoint dp1 = new DataPoint("Applied", "M_H_SM_A");
      dcSM.Add(dp1);
      dcHire.Add(dcSM);

      DataComponent dcGraudates = new DataNode("Graudates");
      DataPoint dpA = new DataPoint("Applied", "M_G_A");
      dcGraudates.Add(dpA);
      DataPoint dpGS = new DataPoint("Applied", "M_G_S");
      dcGraudates.Add(dpGS);
      dcMale.Add(dcGraudates);

      Assert.AreEqual("\nMale\nHire\nAll\n--Applied, M_H_A_A\nSM\n--Applied, M_H_SM_A\nGraudates\n--Applied, M_G_A\n--Applied, M_G_S",
        dcMale.Print());
    }

    [TestMethod]
    public void Compare_DataComponent()
    {
      DataComponent dcComponent = GetOneLevelDataComponent();

      DataComponent dcFilterMale = new DataNode("Male");
      DataComponent dcFilterHire = new DataNode("Hire");
      DataComponent dcFilterSM = new DataNode("SM");
      dcFilterHire.Add(dcFilterSM);
      dcFilterMale.Add(dcFilterHire);

      DataComponent result = new DataNode("Result");
      var r = dcComponent.Compare(dcFilterMale, result);
      Assert.AreEqual(@"
Result
SM
--Applied, M_H_SM_A
--ShortListed, M_H_SM_S",r.Print());
    }

    private static DataComponent GetOneLevelDataComponent()
    {
      DataComponent dcComponent = new DataNode("Component");
      DataComponent dcMale = new DataNode("Male");
      DataComponent dcHire = new DataNode("Hire");
      dcMale.Add(dcHire);

      DataComponent dcSM = new DataNode("SM");
      DataPoint dp1 = new DataPoint("Applied", "M_H_SM_A");
      dcSM.Add(dp1);
      DataPoint dp2 = new DataPoint("ShortListed", "M_H_SM_S");
      dcSM.Add(dp2);
      dcHire.Add(dcSM);

      DataComponent dcAll = new DataNode("All");
      DataPoint dp = new DataPoint("Applied", "M_H_A_A");
      dcHire.Add(dcAll);
      dcAll.Add(dp);
      DataPoint dpS = new DataPoint("ShortListed", "M_H_A_S");
      dcAll.Add(dpS);

      dcComponent.Add(dcMale);
      return dcComponent;
    }

    [TestMethod]
    public void Compare_Two_DataComponent_Graudates()
    {
      DataComponent dcComponent = GetDataComponent();

      DataComponent dcRoot= new DataNode("Root");
      DataComponent dcFilterMale = new DataNode("Male");
      DataComponent dcFilterGraudates = new DataNode("Graudates");
      dcFilterMale.Add(dcFilterGraudates);
      dcRoot.Add(dcFilterMale);

      DataComponent result = new DataNode("Result");
      var r = dcComponent.Compare(dcRoot, result);
      Assert.AreEqual(@"
Result
Graudates
--Applied, M_G_A
--ShortListed, M_G_S", r.Print());
    }

    private static DataComponent GetDataComponent()
    {
      DataComponent dcComponent = new DataNode("Component");
      DataComponent dcMale = new DataNode("Male");
      DataComponent dcHire = new DataNode("Hire");
      dcMale.Add(dcHire);
      dcComponent.Add(dcMale);

      DataComponent dcSM = new DataNode("SM");
      DataPoint dp1 = new DataPoint("Applied", "M_H_SM_A");
      dcSM.Add(dp1);
      DataPoint dp2 = new DataPoint("ShortListed", "M_H_SM_S");
      dcSM.Add(dp2);
      dcHire.Add(dcSM);

      DataComponent dcAll = new DataNode("All");
      DataPoint dp = new DataPoint("Applied", "M_H_A_A");
      dcHire.Add(dcAll);
      dcAll.Add(dp);
      DataPoint dpS = new DataPoint("ShortListed", "M_H_A_S");
      dcAll.Add(dpS);

      DataComponent dcGraudates = new DataNode("Graudates");
      DataPoint dpA = new DataPoint("Applied", "M_G_A");
      dcGraudates.Add(dpA);
      DataPoint dpGS = new DataPoint("ShortListed", "M_G_S");
      dcGraudates.Add(dpGS);
      dcMale.Add(dcGraudates);
      return dcComponent;
    }

    [TestMethod]
    public void Compare_Two_DataComponent_All()
    {
      DataComponent dcComponent = GetDataComponent();

      DataComponent dcRoot = new DataNode("Root");
      DataComponent dcFilterMale = new DataNode("Male");
      DataComponent dcFilterGraudates = new DataNode("All");
      dcFilterMale.Add(dcFilterGraudates);
      dcRoot.Add(dcFilterMale);

      DataComponent result = new DataNode("Result");
      var r = dcComponent.Compare(dcRoot, result);
      Assert.AreEqual(@"
Result
All
--Applied, M_H_A_A
--ShortListed, M_H_A_S", r.Print());
    }

    [TestMethod]
    public void Compare_Two_DataComponent_SM()
    {
      DataComponent dcComponent = GetDataComponent();

      DataComponent dcRoot = new DataNode("Root");
      DataComponent dcFilterMale = new DataNode("Male");
      DataComponent dcFilterGraudates = new DataNode("SM");
      dcFilterMale.Add(dcFilterGraudates);
      dcRoot.Add(dcFilterMale);

      DataComponent result = new DataNode("Result");
      var r = dcComponent.Compare(dcRoot, result);
      Assert.AreEqual(@"
Result
SM
--Applied, M_H_SM_A
--ShortListed, M_H_SM_S", r.Print());
    }

    private static DataComponent GetThreeLevelDataComponent()
    {
      DataComponent dcComponent = GetDataComponent();
      DataComponent dcFemale = new DataNode("Female");
      DataComponent dcHire = new DataNode("Hire");
      dcFemale.Add(dcHire);
      dcComponent.Add(dcFemale);

      DataComponent dcSM = new DataNode("SM");
      DataPoint dp1 = new DataPoint("Applied", "F_H_SM_A");
      dcSM.Add(dp1);
      DataPoint dp2 = new DataPoint("ShortListed", "F_H_SM_S");
      dcSM.Add(dp2);
      dcHire.Add(dcSM);

      DataComponent dcAll = new DataNode("All");
      DataPoint dp = new DataPoint("Applied", "F_H_A_A");
      dcHire.Add(dcAll);
      dcAll.Add(dp);
      DataPoint dpS = new DataPoint("ShortListed", "F_H_A_S");
      dcAll.Add(dpS);

      DataComponent dcGraudates = new DataNode("Graudates");
      DataPoint dpA = new DataPoint("Applied", "F_G_A");
      dcGraudates.Add(dpA);
      DataPoint dpGS = new DataPoint("ShortListed", "F_G_S");
      dcGraudates.Add(dpGS);
      dcFemale.Add(dcGraudates);
      return dcComponent;
    }

    [TestMethod]
    public void Compare_Three_DataComponent_SM()
    {
      DataComponent dcComponent = GetThreeLevelDataComponent();

      DataComponent dcRoot = new DataNode("Root");
      DataComponent dcFilterMale = new DataNode("Female");
      DataComponent dcFilterGraudates = new DataNode("SM");
      dcFilterMale.Add(dcFilterGraudates);
      dcRoot.Add(dcFilterMale);

      DataComponent result = new DataNode("Result");
      var r = dcComponent.Compare(dcRoot, result);
      Assert.AreEqual(@"
Result
SM
--Applied, F_H_SM_A
--ShortListed, F_H_SM_S", r.Print());
    }

    [TestMethod]
    public void Compare_Three_DataComponent_All()
    {
      DataComponent dcComponent = GetThreeLevelDataComponent();

      DataComponent dcRoot = new DataNode("Root");
      DataComponent dcFilterMale = new DataNode("Female");
      DataComponent dcFilterGraudates = new DataNode("All");
      dcFilterMale.Add(dcFilterGraudates);
      dcRoot.Add(dcFilterMale);

      DataComponent result = new DataNode("Result");
      var r = dcComponent.Compare(dcRoot, result);
      Assert.AreEqual(@"
Result
All
--Applied, F_H_A_A
--ShortListed, F_H_A_S", r.Print());
    }

    [TestMethod]
    public void Compare_Three_DataComponent_Graudates()
    {
      DataComponent dcComponent = GetThreeLevelDataComponent();

      DataComponent dcRoot = new DataNode("Root");
      DataComponent dcFilterMale = new DataNode("Female");
      DataComponent dcFilterGraudates = new DataNode("Graudates");
      dcFilterMale.Add(dcFilterGraudates);
      dcRoot.Add(dcFilterMale);

      DataComponent result = new DataNode("Result");
      var r = dcComponent.Compare(dcRoot, result);
      Assert.AreEqual(@"
Result
Graudates
--Applied, F_G_A
--ShortListed, F_G_S", r.Print());
    }

    [TestMethod]
    public void HasNode_In_DataPoint_ReturnsFalse()
    {
      DataPoint dp = new DataPoint("Applied", "M_H_A_A");
      Assert.AreEqual(false, dp.AllChildAreLeafs());
    }

    [TestMethod]
    public void AllChildAreLeafs_In_DataNode_With_NoNodes_ReturnsTrue()
    {
      DataComponent dcAll = new DataNode("All");
      DataPoint dp = new DataPoint("Applied", "M_H_A_A");
      dcAll.Add(dp);
      Assert.AreEqual(true, dcAll.AllChildAreLeafs());
    }

    [TestMethod]
    public void AllChildAreLeafs_In_DataNode_With_Nodes_ReturnsFalse()
    {
      DataComponent dcAll = new DataNode("All");
      DataComponent dcHire = new DataNode("Hire");
      DataPoint dp = new DataPoint("Applied", "M_H_A_A");
      dcHire.Add(dcAll);
      dcAll.Add(dp);
      Assert.AreEqual(false, dcHire.AllChildAreLeafs());
    }
  }
}
