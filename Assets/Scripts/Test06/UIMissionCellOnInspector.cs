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
        base.OnInspectorGUI(); //������
        UIMissionCell cell= this.target as UIMissionCell;//Ŀ���� ����Ʈ��� ������Ʈ
        GUILayout.Space(10);//10�ȼ����� ���

        if (cell.GetGoal() >= 0)
        {
            //�÷��� ������ �����ֱ�
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("0");
            this.SliderValue = EditorGUILayout.IntSlider(this.SliderValue, 0, cell.GetGoal());//
            GUILayout.Label(cell.GetGoal().ToString());
            GUILayout.EndHorizontal();

            if (GUILayout.Button("Apply Count"))
            {
                Debug.Log("�̼� ���� ���� �ݿ��մϴ�.");
                cell.ApplyCount(this.SliderValue);//UIMissionCell�� applyCount�޼��� ȣ��
            }//�߰��Ѱ�
        }
    }
}
