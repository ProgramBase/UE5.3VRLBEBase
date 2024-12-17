using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VOIPTalker")]
	public partial class UVOIPTalker : UActorComponent, IStaticClass
	{
		public FVoiceSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FVoiceSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VOIPTalker");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RegisterWithPlayerState(APlayerState OwningState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwningState?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterWithPlayerState, __InBuffer);
			}
		}

		public virtual float GetVoiceLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetVoiceLevel, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static UVOIPTalker CreateTalkerForPlayer(APlayerState OwningState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwningState?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateTalkerForPlayer, __InBuffer, __ReturnBuffer);

				return *(UVOIPTalker*)__ReturnBuffer;
			}
		}

		public virtual void BPOnTalkingEnd()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __BPOnTalkingEnd);
			}
		}

		public virtual void BPOnTalkingBegin(UAudioComponent AudioComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AudioComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BPOnTalkingBegin, __InBuffer);
			}
		}

		private static uint __Settings = 0;

		private static uint __RegisterWithPlayerState = 0;

		private static uint __GetVoiceLevel = 0;

		private static uint __CreateTalkerForPlayer = 0;

		private static uint __BPOnTalkingEnd = 0;

		private static uint __BPOnTalkingBegin = 0;
	}
}