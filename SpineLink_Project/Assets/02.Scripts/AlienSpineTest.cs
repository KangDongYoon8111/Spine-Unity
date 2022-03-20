using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 스파인 사용을 위한 라이브러리 임포트
using Spine;
using Spine.Unity;

public class AlienSpineTest : MonoBehaviour
{
    // 스켈레톤애니메이션을 컨트롤하기 위하여 변수로 참조
    private SkeletonAnimation skeletonAnimation;

    /* 01
    private void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();

        // SetAnimation(인덱스, 애니메이션 이름, 애니메이션 반복)
        skeletonAnimation.state.SetAnimation(0, "run", true);
    }*/

    /* 02
    private void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();

        // AddAnimation(인덱스, 애니메이션 이름, 애니메이션 반복, 재생 전 지연시간)
        // Add : 추가 / 연속&연결된 애니메이션의 재생에 사용 
        skeletonAnimation.state.AddAnimation(0, "run", false, 0);
        skeletonAnimation.state.AddAnimation(0, "jump", false, 0);
        skeletonAnimation.state.AddAnimation(0, "hit", false, 0);
        skeletonAnimation.state.AddAnimation(0, "death", false, 1); //1초 지연

    } */

    /* 03
    private void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();

        // 애니메이션이 재생되는 속도의 조절은 '타임 스케일'을 이용하여 코드상에서 제어할 수 있다.
        // 1.0 = 100% / 0.0 = 0% / 0.1 = 10% / 2.0 = 200%
        skeletonAnimation.state.TimeScale = 0.5f;

        skeletonAnimation.state.SetAnimation(0, "run", true);
    } */
}
