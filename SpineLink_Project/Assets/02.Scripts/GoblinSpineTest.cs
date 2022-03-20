using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 스파인 사용을 위한 라이브러리 임포트
using Spine;
using Spine.Unity;

public class GoblinSpineTest : MonoBehaviour
{
    // 스켈레톤애니메이션을 컨트롤하기 위하여 변수로 참조
    private SkeletonAnimation skeletonAnimation;

    /* 01
    void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();

        // SetSkin 메서드를 이용하여 스킨을 지정 
        skeletonAnimation.skeleton.SetSkin("goblin");
        skeletonAnimation.skeleton.SetSlotsToSetupPose();
    }*/

    void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();

        // SetSkin 메서드를 이용하여 스킨을 지정 
        skeletonAnimation.skeleton.SetSkin("goblin");
        skeletonAnimation.skeleton.SetSlotsToSetupPose();

        // 애니메이션 지정
        skeletonAnimation.state.SetAnimation(0, "walk", true);
    }

    void Update()
    {
        // 게임 중 마우스 왼쪽 버튼 클릭 시 여성 고블린으로 스킨 변경 
        if (Input.GetMouseButtonDown(0))
        {
            skeletonAnimation.skeleton.SetSkin("goblingirl");
            skeletonAnimation.skeleton.SetSlotsToSetupPose();

            // 어태치먼트 변경 : 여성 고블린으로 스킨 변경 시 왼손에 쥐고 있는 무기도 변경 
            skeletonAnimation.skeleton.SetAttachment("left-hand-item", "dagger");
            // 오른손에 쥐고 있는 무기 비활성
            skeletonAnimation.skeleton.SetAttachment("right-hand-item", null);
        }
    }
}
