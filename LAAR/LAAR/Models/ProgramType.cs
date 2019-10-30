using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblProgramType")]
    public class ProgramType
    {
        /*
            //Maladaptive Bejavior
            Tantrum
            Physical Aggressive Behavior
            Verbal Aggressive Behavior
            Elopement
            Self-Injurious Behavior (SIB)
            Sensory Stimulatory Behavior
            Task Refusal
            Rapid Eating
            Manding Repetition
            Property Destruction
            Hypersensitivity
            Repetitive Behavior
            Repetitive Vocalization
            Conversation Interruptions
            Other:  
        */
        /*
            // Interventions
            Pairing Procedures
            High-P
            Shaping
            Chaining
            Premack Principle
            Response Cost
            Token Economy
            Escape Extinction
            Escape independent response delivery 
            Differential Reinforcement of Alternative Behaviors (DRA)
            Differential Reinforcement of Incompatible Behavior (DRI)
            Differential Reinforcement of Other Behavior (DRO)
            Differential Reinforcement of High Rates of Behavior (DRH)
            Differential Reinforcement of Low Rates of Behavior (DRL)
            Planned Ignoring
            Redirection
            Response Block
            Errorless Teaching 
            Attention Independent Response Delivery 
            Thinning Response independent attention delivery
            Preventive Strategies (antecedent-based)
            Other: 
        */
        /*
            //Replacement Programs
            Functional Communication
            Requesting/Asking for Tangibles
            Requesting/Asking for Break
            Requesting/Asking for Attention
            Asking for Help/Assistance
            Relaxation Training
            Safety Program
            Sharing, taking turns (Playing Skills)
            Social Skills
            Delay of Reinforcement/Waiting for Tangible
            Delay of Attention
            Following Instructions
            Sensory Alternatives/Sensory Enrichment Activity
            Time on task
            Tacting     
            Echoics
            Verbal and Motor Imitation
            Toilet Training
            Systematic Desensitization
            Greetings
            Responding to name
            Eating Training
            Self-Care Skills
            Compliance Training/Activity Schedule 
            Other: 
        */

        [Key]
        public int ProgramTypeID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // Maladaptive Behavior, Intervention, Replacement
        public string UnitOfMeasurement { get; set; } //Incidents, Oportunities, Time
    }
}