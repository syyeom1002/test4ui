using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.TerrainTools;

[CustomEditor(typeof(UIMissionCell))]
public class UIMissionCellOnInspector : Editor
{
    private int SliderValue;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI(); //기존꺼
        UIMissionCell cell= this.target as UIMissionCell;//커스텀 에디트대상 컴포넌트
        GUILayout.Space(10);//10픽셀정도 띤다

        if (cell.GetGoal() >= 0)
        {
            //플레이 했을때 보여주기
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("0");
            this.SliderValue = EditorGUILayout.IntSlider(this.SliderValue, 0, cell.GetGoal());//
            GUILayout.Label(cell.GetGoal().ToString());
            GUILayout.EndHorizontal();

            if (GUILayout.Button("Apply Count"))
            {
                Debug.Log("미션 진행 수를 반영합니다.");
                cell.ApplyCount(this.SliderValue);//UIMissionCell의 applyCount메서드 호출
            }//추가한거
        }
    }
}
