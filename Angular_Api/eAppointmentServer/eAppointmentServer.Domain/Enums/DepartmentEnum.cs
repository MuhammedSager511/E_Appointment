using Ardalis.SmartEnum;

namespace eAppointmentServer.Domain.Enums;
public sealed class DepartmentEnum : SmartEnum<DepartmentEnum>
{
    public static readonly DepartmentEnum Acil = new("Acil", 1);
    public static readonly DepartmentEnum X_rays = new("X_Rays", 2);//الأشعة
    public static readonly DepartmentEnum Heartdisease = new("Heartdisease", 3);//أمراض القلب
    public static readonly DepartmentEnum Dermatology = new("Dermatology", 4);//الأمراض الجلدية
    public static readonly DepartmentEnum Endocrinology = new("Endocrinology", 5);//الغدد الصماء
    public static readonly DepartmentEnum Gastroenterology = new("Gastroenterology", 6);//أمراض الجهاز الهضمي
    public static readonly DepartmentEnum GeneralSurgery = new("General Surgery", 7); //الجراحة العامة
    public static readonly DepartmentEnum GynecologyandObstetrics = new("Gynecology and Obstetrics", 8);//وأمراض النساء والتوليد
    public static readonly DepartmentEnum Hematology = new("Hematology", 9);//أمراض الدم
    public static readonly DepartmentEnum InfectiousDiseasesi = new("Infectious Diseases", 10);//أمراض معدية
    public static readonly DepartmentEnum Nephrology = new("Nephrology", 11);//أمراض الكلى 
    public static readonly DepartmentEnum neurology = new("neurology", 12);//علم الأعصاب
    public static readonly DepartmentEnum orthopedics = new("orthopedics", 13); //طب العظام
    public static readonly DepartmentEnum Pediatricians = new("Pediatricians", 14);//أطباء الأطفال
    public static readonly DepartmentEnum Psychiatry = new("Psychiatry", 15); //الطب النفسي
    public static readonly DepartmentEnum Pulmonology = new("Pulmonology", 16);//أمراض الرئة
    public DepartmentEnum(string name, int value) : base(name, value)
    {
    }
}
