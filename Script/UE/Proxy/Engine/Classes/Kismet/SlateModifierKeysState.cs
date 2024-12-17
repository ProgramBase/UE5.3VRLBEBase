using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SlateModifierKeysState")]
	public partial class FSlateModifierKeysState : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SlateModifierKeysState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSlateModifierKeysState() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSlateModifierKeysState() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSlateModifierKeysState A, FSlateModifierKeysState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSlateModifierKeysState A, FSlateModifierKeysState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSlateModifierKeysState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public byte ModifierKeysStateMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModifierKeysStateMask, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModifierKeysStateMask, __InBuffer);
				}
			}
		}

		private static uint __ModifierKeysStateMask = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}