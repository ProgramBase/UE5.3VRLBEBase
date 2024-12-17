using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.NavLocalGridManager")]
	public partial class UNavLocalGridManager : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.NavLocalGridManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool SetLocalNavigationGridDensity(UObject WorldContextObject, float CellSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = CellSize;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetLocalNavigationGridDensity, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void RemoveLocalNavigationGrid(UObject WorldContextObject, int GridId, bool bRebuildGrids = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = GridId;

				*(bool*)(__InBuffer + 12) = bRebuildGrids;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveLocalNavigationGrid, __InBuffer);
			}
		}

		public static bool FindLocalNavigationGridPath(UObject WorldContextObject, FVector Start, FVector End, ref TArray<FVector> PathPoints)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = PathPoints?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __FindLocalNavigationGridPath, __InBuffer, __OutBuffer, __ReturnBuffer);

				PathPoints = *(TArray<FVector>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int AddLocalNavigationGridForPoints(UObject WorldContextObject, TArray<FVector> Locations, int Radius2D = 5, float Height = 100.000000f, bool bRebuildGrids = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Locations?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Radius2D;

				*(float*)(__InBuffer + 20) = Height;

				*(bool*)(__InBuffer + 24) = bRebuildGrids;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddLocalNavigationGridForPoints, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int AddLocalNavigationGridForPoint(UObject WorldContextObject, FVector Location, int Radius2D = 5, float Height = 100.000000f, bool bRebuildGrids = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Radius2D;

				*(float*)(__InBuffer + 20) = Height;

				*(bool*)(__InBuffer + 24) = bRebuildGrids;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddLocalNavigationGridForPoint, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int AddLocalNavigationGridForCapsule(UObject WorldContextObject, FVector Location, float CapsuleRadius, float CapsuleHalfHeight, int Radius2D = 5, float Height = 100.000000f, bool bRebuildGrids = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = CapsuleRadius;

				*(float*)(__InBuffer + 20) = CapsuleHalfHeight;

				*(int*)(__InBuffer + 24) = Radius2D;

				*(float*)(__InBuffer + 28) = Height;

				*(bool*)(__InBuffer + 32) = bRebuildGrids;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddLocalNavigationGridForCapsule, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int AddLocalNavigationGridForBox(UObject WorldContextObject, FVector Location, FVector Extent = null, FRotator Rotation = null, int Radius2D = 5, float Height = 100.000000f, bool bRebuildGrids = true)
		{
			unsafe
			{
				Extent ??= new FVector(1.000000, 1.000000, 1.000000);

				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Extent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 32) = Radius2D;

				*(float*)(__InBuffer + 36) = Height;

				*(bool*)(__InBuffer + 40) = bRebuildGrids;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddLocalNavigationGridForBox, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __SetLocalNavigationGridDensity = 0;

		private static uint __RemoveLocalNavigationGrid = 0;

		private static uint __FindLocalNavigationGridPath = 0;

		private static uint __AddLocalNavigationGridForPoints = 0;

		private static uint __AddLocalNavigationGridForPoint = 0;

		private static uint __AddLocalNavigationGridForCapsule = 0;

		private static uint __AddLocalNavigationGridForBox = 0;
	}
}