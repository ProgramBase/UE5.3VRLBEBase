using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavigationPath")]
	public partial class UNavigationPath : UObject, IStaticClass
	{
		public FOnNavigationPathUpdated PathUpdatedNotifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PathUpdatedNotifier, __ReturnBuffer);

					return *(FOnNavigationPathUpdated*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PathUpdatedNotifier, __InBuffer);
				}
			}
		}

		public TArray<FVector> PathPoints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PathPoints, __ReturnBuffer);

					return *(TArray<FVector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PathPoints, __InBuffer);
				}
			}
		}

		public ENavigationOptionFlag RecalculateOnInvalidation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RecalculateOnInvalidation, __ReturnBuffer);

					return *(ENavigationOptionFlag*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RecalculateOnInvalidation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavigationPath");
		}

		private static UClass StaticClassSingleton { get; set; }

		public new bool IsValid()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsValid, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsStringPulled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsStringPulled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPartial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPartial, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual double GetPathLength()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPathLength, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public virtual double GetPathCost()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPathCost, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public virtual FString GetDebugString()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDebugString, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual void EnableRecalculationOnInvalidation(ENavigationOptionFlag DoRecalculation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)DoRecalculation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EnableRecalculationOnInvalidation, __InBuffer);
			}
		}

		public virtual void EnableDebugDrawing(bool bShouldDrawDebugData, FLinearColor PathColor = null)
		{
			unsafe
			{
				PathColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bShouldDrawDebugData;

				*(nint*)(__InBuffer + 1) = PathColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EnableDebugDrawing, __InBuffer);
			}
		}

		private static uint __PathUpdatedNotifier = 0;

		private static uint __PathPoints = 0;

		private static uint __RecalculateOnInvalidation = 0;

		private static uint __IsValid = 0;

		private static uint __IsStringPulled = 0;

		private static uint __IsPartial = 0;

		private static uint __GetPathLength = 0;

		private static uint __GetPathCost = 0;

		private static uint __GetDebugString = 0;

		private static uint __EnableRecalculationOnInvalidation = 0;

		private static uint __EnableDebugDrawing = 0;
	}
}