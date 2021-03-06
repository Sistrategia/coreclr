using System;
/// <summary>
///Class
/// </summary>

public class AttributeTargetsClass
{
    public static int Main()
    {
        AttributeTargetsClass AttributeTargetsClass = new AttributeTargetsClass();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsClass");
        if (AttributeTargetsClass.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
       TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Class value is 0x0004. ");
        try
        {
            int expectValue = 0x0004;
            if ((int)AttributeTargets.Class != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Class should return 0x0004.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

