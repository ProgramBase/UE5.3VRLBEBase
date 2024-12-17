using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTTask_MoveDirectlyToward")]
	public partial class UBTTask_MoveDirectlyToward : UBTTask_MoveTo, IStaticClass
	{
		public bool bDisablePathUpdateOnGoalLocationChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisablePathUpdateOnGoalLocationChange, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisablePathUpdateOnGoalLocationChange, __InBuffer);
				}
			}
		}

		public bool bProjectVectorGoalToNavigation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bProjectVectorGoalToNavigation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bProjectVectorGoalToNavigation, __InBuffer);
				}
			}
		}

		public bool bUpdatedDeprecatedProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdatedDeprecatedProperties, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdatedDeprecatedProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTTask_MoveDirectlyToward");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bDisablePathUpdateOnGoalLocationChange = 0;

		private static uint __bProjectVectorGoalToNavigation = 0;

		private static uint __bUpdatedDeprecatedProperties = 0;
	}
}