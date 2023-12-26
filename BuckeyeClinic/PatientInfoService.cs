using BuckeyeClinic.Model;
// PatientInfoService.cs
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace BuckeyeClinic
{
    public class PatientInfoService
    {
        private readonly PatientInfoDb _context;

        public PatientInfoService(PatientInfoDb context)
        {
            _context = context;
        }

        public List<PatientInfo> GetAllPatientInfos()
        {
            return _context.PatientInfos.ToList();
        }

        public PatientInfo GetPatientInfoById(int id)
        {
            return _context.PatientInfos.FirstOrDefault(p => p.Id == id);
        }

        public void CreatePatientInfo(PatientInfo patientInfo)
        {
            _context.PatientInfos.Add(patientInfo);
            _context.SaveChanges();
        }

        public void UpdatePatientInfo(PatientInfo updatedPatientInfo)
        {
            var existingPatientInfo = _context.PatientInfos.Find(updatedPatientInfo.Id);

            if (existingPatientInfo != null)
            {
                // Update properties of the existing patient info
                existingPatientInfo.FirstName = updatedPatientInfo.FirstName ?? existingPatientInfo.FirstName;
                existingPatientInfo.LastName = updatedPatientInfo.LastName ?? existingPatientInfo.LastName;
                existingPatientInfo.Dos = updatedPatientInfo.Dos ?? existingPatientInfo.Dos;
                existingPatientInfo.Dob = updatedPatientInfo.Dob ?? existingPatientInfo.Dob;
                existingPatientInfo.MRN = updatedPatientInfo.MRN ?? existingPatientInfo.MRN;
                existingPatientInfo.Diagnosis = updatedPatientInfo.Diagnosis ?? existingPatientInfo.Diagnosis;
                existingPatientInfo.ASAM_Level_of_Care_at_Admission = updatedPatientInfo.ASAM_Level_of_Care_at_Admission ?? existingPatientInfo.ASAM_Level_of_Care_at_Admission;
                existingPatientInfo.ASAM_Current_Level_of_Care = updatedPatientInfo.ASAM_Current_Level_of_Care ?? existingPatientInfo.ASAM_Current_Level_of_Care;
                existingPatientInfo.Services_Provided = updatedPatientInfo.Services_Provided ?? existingPatientInfo.Services_Provided;
                existingPatientInfo.Frequency_of_treatment_services = updatedPatientInfo.Frequency_of_treatment_services ?? existingPatientInfo.Frequency_of_treatment_services;
                existingPatientInfo.ITP_Type = updatedPatientInfo.ITP_Type ?? existingPatientInfo.ITP_Type;
                existingPatientInfo.ITP_Last_Review_Date = updatedPatientInfo.ITP_Last_Review_Date ?? existingPatientInfo.ITP_Last_Review_Date;
                existingPatientInfo.CM_included_in_ITP = updatedPatientInfo.CM_included_in_ITP ?? existingPatientInfo.CM_included_in_ITP;
                existingPatientInfo.G1_Problem_Statement = updatedPatientInfo.G1_Problem_Statement ?? existingPatientInfo.G1_Problem_Statement;
                existingPatientInfo.Goal1 = updatedPatientInfo.Goal1 ?? existingPatientInfo.Goal1;
                existingPatientInfo.G1_Objective = updatedPatientInfo.G1_Objective ?? existingPatientInfo.G1_Objective;
                existingPatientInfo.G1_Responsible_Person = updatedPatientInfo.G1_Responsible_Person ?? existingPatientInfo.G1_Responsible_Person;
                existingPatientInfo.G1_Target_Date = updatedPatientInfo.G1_Target_Date ?? existingPatientInfo.G1_Target_Date;
                existingPatientInfo.G2_Problem_Statement = updatedPatientInfo.G2_Problem_Statement ?? existingPatientInfo.G2_Problem_Statement;
                existingPatientInfo.Goal2 = updatedPatientInfo.Goal2 ?? existingPatientInfo.Goal2;
                existingPatientInfo.G2_Objective = updatedPatientInfo.G2_Objective ?? existingPatientInfo.G2_Objective;
                existingPatientInfo.G2_Responsible_Person = updatedPatientInfo.G2_Responsible_Person ?? existingPatientInfo.G2_Responsible_Person;
                existingPatientInfo.G2_Target_Date = updatedPatientInfo.G2_Target_Date ?? existingPatientInfo.G2_Target_Date;
                existingPatientInfo.G3_Problem_Statement = updatedPatientInfo.G3_Problem_Statement ?? existingPatientInfo.G3_Problem_Statement;
                existingPatientInfo.Goal3 = updatedPatientInfo.Goal3 ?? existingPatientInfo.Goal3;
                existingPatientInfo.G3_Objective = updatedPatientInfo.G3_Objective ?? existingPatientInfo.G3_Objective;
                existingPatientInfo.G3_Responsible_Person = updatedPatientInfo.G3_Responsible_Person ?? existingPatientInfo.G3_Responsible_Person;
                existingPatientInfo.G3_Target_Date = updatedPatientInfo.G3_Target_Date ?? existingPatientInfo.G3_Target_Date;
                existingPatientInfo.G4_Problem_Statement = updatedPatientInfo.G4_Problem_Statement ?? existingPatientInfo.G4_Problem_Statement;
                existingPatientInfo.Goal4 = updatedPatientInfo.Goal4 ?? existingPatientInfo.Goal4;
                existingPatientInfo.G4_Objective = updatedPatientInfo.G4_Objective ?? existingPatientInfo.G4_Objective;
                existingPatientInfo.G4_Responsible_Person = updatedPatientInfo.G4_Responsible_Person ?? existingPatientInfo.G4_Responsible_Person;
                existingPatientInfo.G4_Target_Date = updatedPatientInfo.G4_Target_Date ?? existingPatientInfo.G4_Target_Date;
                existingPatientInfo.Strengths3 = updatedPatientInfo.Strengths3 ?? existingPatientInfo.Strengths3;
                existingPatientInfo.Weaknesses3 = updatedPatientInfo.Weaknesses3 ?? existingPatientInfo.Weaknesses3;
                existingPatientInfo.Client_Participation = updatedPatientInfo.Client_Participation ?? existingPatientInfo.Client_Participation;
                existingPatientInfo.Client_ParticipationDescription = updatedPatientInfo.Client_ParticipationDescription ?? existingPatientInfo.Client_ParticipationDescription;
                existingPatientInfo.ParticipationbyOthers = updatedPatientInfo.ParticipationbyOthers ?? existingPatientInfo.ParticipationbyOthers;
                existingPatientInfo.Counselor = updatedPatientInfo.Counselor ?? existingPatientInfo.Counselor;
                existingPatientInfo.Supervisor = updatedPatientInfo.Supervisor ?? existingPatientInfo.Supervisor;
                existingPatientInfo.ESign = updatedPatientInfo.ESign ?? existingPatientInfo.ESign;


                _context.SaveChanges();
            }
        }

        // Add a method for deleting patient info if needed
    }
}
