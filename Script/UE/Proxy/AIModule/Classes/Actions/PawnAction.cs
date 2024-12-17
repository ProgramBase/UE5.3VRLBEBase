using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.PawnAction")]
	public partial class UDEPRECATED_PawnAction : UObject, IStaticClass
	{
		public UObject Instigator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Instigator, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Instigator, __InBuffer);
				}
			}
		}

		public UBrainComponent BrainComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrainComp, __ReturnBuffer);

					return *(UBrainComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrainComp, __InBuffer);
				}
			}
		}

		public bool bAllowNewSameClassInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowNewSameClassInstance, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowNewSameClassInstance, __InBuffer);
				}
			}
		}

		public bool bReplaceActiveSameClassInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReplaceActiveSameClassInstance, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReplaceActiveSameClassInstance, __InBuffer);
				}
			}
		}

		public bool bShouldPauseMovement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldPauseMovement, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldPauseMovement, __InBuffer);
				}
			}
		}

		public bool bAlwaysNotifyOnFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysNotifyOnFinished, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysNotifyOnFinished, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.PawnAction");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual EAIRequestPriority GetActionPriority()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetActionPriority, __ReturnBuffer);

				return *(EAIRequestPriority*)__ReturnBuffer;
			}
		}

		public virtual void Finish(EPawnActionResult WithResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)WithResult;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Finish, __InBuffer);
			}
		}

		public static UDEPRECATED_PawnAction CreateActionInstance(UObject WorldContextObject, TSubclassOf<UDEPRECATED_PawnAction> ActionClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActionClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateActionInstance, __InBuffer, __ReturnBuffer);

				return *(UDEPRECATED_PawnAction*)__ReturnBuffer;
			}
		}

		private static uint __Instigator = 0;

		private static uint __BrainComp = 0;

		private static uint __bAllowNewSameClassInstance = 0;

		private static uint __bReplaceActiveSameClassInstance = 0;

		private static uint __bShouldPauseMovement = 0;

		private static uint __bAlwaysNotifyOnFinished = 0;

		private static uint __GetActionPriority = 0;

		private static uint __Finish = 0;

		private static uint __CreateActionInstance = 0;
	}
}