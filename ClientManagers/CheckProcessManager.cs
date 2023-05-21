// 점검을 실질적으로 실행하고, 스케쥴을 관리한다
public class CheckProcessManager : Cook
{
    // 생성자 - 객체가 생성되는 시점에 해 줘야하는 것들 -초기화 작업 등- 을 이곳에 작성해주자
    public CheckProcessManager()
    {

    }

    // CheckStart() 메소득가 반환할 상태값 정의
    public enum CheckResult { Succeed = 0, GeneralError = -1 };

    int CheckProcedureStatus;

    // 이 메소드는 점검을 시작합니다.
    // 입력받는값: void
    // 반환받는값: int(점검의 결과를 반환합니다)
    public int CheckStart()
    {
        if(1 != 0) // 오류조건
        {
            // 오류가 생겼어
            return (int)CheckResult.GeneralError;
        }

        return (int)CheckResult.Succeed;
    }
}