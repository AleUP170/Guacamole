using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
	private static int levelNumber, score;
	private static bool flag;

	public static int LevelNumber
	{
		get
		{
			return levelNumber;
		}

		set
		{
			levelNumber = value;
		}
	}

	public static bool Flag
	{
		get
		{
			return flag;
		}
		set
		{
			flag = value;
		}
	}

	public static int Score
	{
		get
		{
			return score;
		}

		set
		{
			score = value;
		}
	}
}
