namespace VintageSymphony.Situations.Facts;

public struct SituationalFacts
{
	public SituationalFacts()
	{
	}
	
	public float DistanceTravelledTotal;
	public float DistanceTravelledDiagonal;
	public float MovementRadius;
	public int SecondsSinceLastDamage = Int32.MaxValue;
	public float DistanceFromHome;
	public float Time;
	public long Now;
	public float RelativeHeight;
	public float DistanceToSurface;
	public bool IsHoldingWeapon;
	public float EnemyDistance = float.PositiveInfinity;
	public const float EnemyDistanceMax = 50f;
	public float RiftDistance = float.PositiveInfinity;
	public float SunLevel;
	public const float SunLevelMax = 32f;
	public bool Alive;
}