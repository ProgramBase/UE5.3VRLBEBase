using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DialogueContext")]
	public partial class FDialogueContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DialogueContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDialogueContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDialogueContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDialogueContext A, FDialogueContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDialogueContext A, FDialogueContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDialogueContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UDialogueVoice Speaker
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Speaker, __ReturnBuffer);

					return *(UDialogueVoice*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Speaker, __InBuffer);
				}
			}
		}

		public TArray<UDialogueVoice> Targets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Targets, __ReturnBuffer);

					return *(TArray<UDialogueVoice>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Targets, __InBuffer);
				}
			}
		}

		private static uint __Speaker = 0;

		private static uint __Targets = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}