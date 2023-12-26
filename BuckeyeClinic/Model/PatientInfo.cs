using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuckeyeClinic.Model
{
    [Table("PatientInfo")]
    public class PatientInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // Assuming you have an identity column as primary key

        // Personal Information
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Dos { get; set; }
        public DateTime? Dob { get; set; }
        public string? MRN { get; set; }

        // Diagnosis and ASAM Information
        public string? Diagnosis { get; set; }
        public string? ASAM_Level_of_Care_at_Admission { get; set; }
        public string? ASAM_Current_Level_of_Care { get; set; }

        // Treatment Information
        public int? Services_Provided { get; set; }
        public string? Frequency_of_treatment_services { get; set; }

        // ITP Information
        public int? ITP_Type { get; set; }
        public DateTime? ITP_Last_Review_Date { get; set; }
        public bool? CM_included_in_ITP { get; set; }

        // Goals Information (G1)
        public string? G1_Problem_Statement { get; set; }
        public string? Goal1 { get; set; }
        public string? G1_Objective { get; set; }
        public string? G1_Responsible_Person { get; set; }
        public DateTime? G1_Target_Date { get; set; }

        // Goals Information (G2)
        public string? G2_Problem_Statement { get; set; }
        public string? Goal2 { get; set; }
        public string? G2_Objective { get; set; }
        public string? G2_Responsible_Person { get; set; }
        public DateTime? G2_Target_Date { get; set; }

        // Goals Information (G3)
        public string? G3_Problem_Statement { get; set; }
        public string? Goal3 { get; set; }
        public string? G3_Objective { get; set; }
        public string? G3_Responsible_Person { get; set; }
        public DateTime? G3_Target_Date { get; set; }

        // Goals Information (G4)
        public string? G4_Problem_Statement { get; set; }
        public string? Goal4 { get; set; }
        public string? G4_Objective { get; set; }
        public string? G4_Responsible_Person { get; set; }
        public DateTime? G4_Target_Date { get; set; }

        // Additional Information
        public string? Strengths3 { get; set; }
        public string? Weaknesses3 { get; set; }
        public int? Client_Participation { get; set; }
        public string? Client_ParticipationDescription { get; set; }
        public string? ParticipationbyOthers { get; set; }
        public string? Counselor { get; set; }
        public string? Supervisor { get; set; }

        // Electronic Signature
        public byte[]? ESign { get; set; } // Assuming ESign is varbinary
    }
}
