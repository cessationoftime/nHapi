using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V22.Segment;
using System.Linq;
using NHapi.Base.Model;

namespace NHapi.Model.V22.Group
{
///<summary>
///Represents the ORU_R01_ORDER_OBSERVATION Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: ORC (COMMOM ORDER) optional </li>
///<li>1: OBR (OBSERVATION REQUEST) </li>
///<li>2: NTE (NOTES AND COMMENTS) optional repeating</li>
///<li>3: ORU_R01_OBSERVATION (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class ORU_R01_ORDER_OBSERVATION : AbstractGroup {

	///<summary> 
	/// Creates a new ORU_R01_ORDER_OBSERVATION Group.
	///</summary>
	public ORU_R01_ORDER_OBSERVATION(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), false, false);
	      this.add(typeof(OBR), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(ORU_R01_OBSERVATION), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORU_R01_ORDER_OBSERVATION - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns ORC (COMMOM ORDER) - creates it if necessary
	///</summary>
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.GetStructure("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns OBR (OBSERVATION REQUEST) - creates it if necessary
	///</summary>
	public OBR OBR { 
get{
	   OBR ret = null;
	   try {
	      ret = (OBR)this.GetStructure("OBR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NTE (NOTES AND COMMENTS) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (NOTES AND COMMENTS) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of ORU_R01_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public ORU_R01_OBSERVATION GetOBSERVATION() {
	   ORU_R01_OBSERVATION ret = null;
	   try {
	      ret = (ORU_R01_OBSERVATION)this.GetStructure("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORU_R01_OBSERVATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORU_R01_OBSERVATION GetOBSERVATION(int rep) { 
	   return (ORU_R01_OBSERVATION)this.GetStructure("OBSERVATION", rep);
	}


    /// <summary>
    /// Inserts a specific repetition of OBSERVATION (a Group object)
    /// </summary>
    /// <param name="rep">index to insert at</param>
    /// <param name="renumberSetIDs">should setIDs be renumbered after insert?</param>
    /// <returns>the inserted group</returns>
    public ORU_R01_OBSERVATION insertOBSERVATION(int rep, bool renumberSetIDs = true)
    {
        var obs = (ORU_R01_OBSERVATION)insertRepetition("OBSERVATION", rep);
        if (renumberSetIDs) renumberObservationOBXSETIDs();
        return obs;
    }


    /// <summary>
    /// Renumbers the SETIDs of Observation/OBX segments
    /// </summary>
    public void renumberObservationOBXSETIDs()
    {
        var obs = getOBSERVATIONAll();

        for (int x = 0; x < obs.Count(); x++)
        {
            obs[x].OBX.SetIDObservationalSimple.Value = (x + 1).ToString();
        }
    }

    /// <summary>
    /// Removes a specific repetition of OBSERVATION (a Group object)
    /// </summary>
    /// <param name="rep">index to remove at</param>
    /// <param name="renumberSetIDs">should setIDs be renumbered after insert?</param>
    /// <returns>The removed group</returns>
    public ORU_R01_OBSERVATION removeOBSERVATION(int rep, bool renumberSetIDs = true)
    {
        var obs = (ORU_R01_OBSERVATION)removeRepetition("OBSERVATION", rep);
        if (renumberSetIDs) renumberObservationOBXSETIDs();
        return obs;
    }

    /// <summary>
    /// get all Observation structures
    /// </summary>
    /// <returns></returns>
    public ORU_R01_OBSERVATION[] getOBSERVATIONAll()
    {
        return this.GetAll("OBSERVATION").Cast<ORU_R01_OBSERVATION>().ToArray();
    }

	/** 
	 * Returns the number of existing repetitions of ORU_R01_OBSERVATION 
	 */ 
	public int OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
