using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	public float speedUp = 60f;

	public GOBs.Goal Goal_Eat;
	public GOBs.Goal Goal_Bathroom;

	public GOBs.Action Action_EatSnack;
	public GOBs.Action Action_EatMeal;
	public GOBs.Action Action_VisitBathroom;

	
	void Start()
	{
		Goal_Eat = new()
		{
			name = "Eat",
			value = 4f,
			changeRate = 4f /speedUp,
		};

		Goal_Bathroom = new()
		{
			name = "Bathroom",
			value = 3f,
			changeRate = 2f /speedUp,
		};


		Action_EatSnack = new()
		{
			targetGoals = new GOBs.Goal[] {
				Goal_Eat,
			},
			changes = new float[] {
				-2f,
			},
			duration = 15f/60f /speedUp,
		};

		Action_EatMeal = new()
		{
			targetGoals = new GOBs.Goal[] {
				Goal_Eat,
			},
			changes = new float[] {
				-4f,
			},
			duration = 1f /speedUp,
		};

		Action_VisitBathroom = new()
		{
			targetGoals = new GOBs.Goal[] {
				Goal_Bathroom,
			},
			changes = new float[] {
				-4f,
			},
			duration = 15f/60f /speedUp,
		};
	}
}