using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputActionSpeechMapping")]
	public partial class FInputActionSpeechMapping : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InputActionSpeechMapping");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInputActionSpeechMapping() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInputActionSpeechMapping() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInputActionSpeechMapping A, FInputActionSpeechMapping B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInputActionSpeechMapping A, FInputActionSpeechMapping B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInputActionSpeechMapping;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ActionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActionName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActionName, __InBuffer);
				}
			}
		}

		public FName SpeechKeyword
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpeechKeyword, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpeechKeyword, __InBuffer);
				}
			}
		}

		private static uint __ActionName = 0;

		private static uint __SpeechKeyword = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}