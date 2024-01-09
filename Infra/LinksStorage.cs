namespace SeleniumAndNUnit;

public class LinksStorage 
    
{
    private static readonly string MainUrl = "https://normativ.kontur.ru/";

    public static string mainPageUrl => CombineUrls("");
    public static string WebinarsPageUrl => CombineUrls("webinars");
    public static string DocumentOrderPageUrl => CombineUrls("document-order/order");
    public static string QaAskQuestionPageUrl => CombineUrls("consult/ask-question");
    public static string QaSharedQuestionsPageUrl => CombineUrls("consult/shared-questions");
    public static string BuhCalendarPageUrl => CombineUrls("buhcalendar");
    public static string DecreeCalcPageUrl => CombineUrls("calculators/decree");
    public static string HositalCalcPageUrl => CombineUrls("calculators/hospital");
    public static string PeniCalcPageUrl => CombineUrls("calculators/peni");
    public static string UsnCalcPageUrl => CombineUrls("calculators/usn");
    public static string VacationCalcPageUrl => CombineUrls("calculators/vacation");
    

    private static string CombineUrls(string relativePath) => $"{MainUrl}{relativePath}";
}

