using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Food
    { 
        [Required]
        public int Id {get; set;}
        [Required]        
        public string Name {get; set;}
        public float Water_g {get; set;}
        public float Energy_kcal {get; set;}
        public float Protein_g {get; set;}
        public float Lipid_Tot_g {get; set;}
        public float Ash_g {get; set;}
        public float Carbohydrt_g {get; set;}
        public float Fiber_TD_g {get; set;}
        public float Sugar_Tot_g {get; set;}
        public float Calcium_mg {get; set;}
        public float Iron_mg {get; set;}
        public float Magnesium_mg {get; set;}
        public float Phosphorus_mg {get; set;}
        public float Potassium_mg {get; set;}
        public float Sodium_mg {get; set;}
        public float Zinc_mg {get; set;}
        public float Copper_mg {get; set;}
        public float Manganese_mg {get; set;}
        public float Selenium_microg {get; set;}
        public float Vit_C_mg {get; set;}
        public float Thiamin_mg {get; set;}
        public float Riboflavin_mg {get; set;}
        public float Niacin_mg {get; set;}
        public float Panto_Acid_mg {get; set;}
        public float Vit_B6_mg {get; set;}
        public float Folate_Tot_microg {get; set;}
        public float Folic_Acid_microg {get; set;}
        public float Food_Folate_microg {get; set;}
        public float Folate_DFE_microg {get; set;}
        public float Choline_Tot_mg {get; set;}
        public float Vit_B12_microg {get; set;}
        public float Vit_A_IU {get; set;}
        public float Vit_A_RAE {get; set;}
        public float Retinol_microg {get; set;}
        public float Alpha_Carot_microg {get; set;}
        public float Beta_Carot_microg {get; set;}
        public float Beta_Crypt_microg {get; set;}
        public float Lycopene_microg {get; set;}
        public float Lut_Zea_microg {get; set;}
        public float Vit_E_mg {get; set;}
        public float Vit_D_microg {get; set;}
        public float Vit_D_IU {get; set;}
        public float Vit_K_microg {get; set;}
        public float FA_Sat_g {get; set;}
        public float FA_Mono_g {get; set;}
        public float FA_Poly_g {get; set;}
        public float Cholestrl_mg {get; set;}
        public float GmWt_1 {get; set;}
        public string GmWt_Desc1 {get; set;}
        public float GmWt_2 {get; set;}
        public string GmWt_Desc2 {get; set;}
        public float Refuse_Pct {get; set;}
    }
}
