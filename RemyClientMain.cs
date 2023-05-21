internal class RemyClientMain
{
    private static void Main(string[] args)
    {
        // CheckProcessManager 객체를 만들고, CheckStart() 할거에요
        CheckProcessManager checkInstance = new CheckProcessManager();

        int checkResult = checkInstance.CheckStart();
        switch(checkResult)
        {
            case (int)CheckProcessManager.CheckResult.Succeed:
            {
                Console.WriteLine("점검이 정상적으로 종료 되었습니다.");
            }
            break;
            case (int)CheckProcessManager.CheckResult.GeneralError:
            {
                Console.WriteLine("점검중에 일반오류 발생!!!");
            }
            break;
            default:
            {
                Console.WriteLine("정의되지 않은 오류가 발생했습니다!!");
            }
            break;
        }  
    }
}