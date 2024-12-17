using Script.CoreUObject;
using Script.Library;

namespace Script.MaterialEditor
{
	[PathName("/Script/MaterialEditor.CheckerboardSettings")]
	public partial class FCheckerboardSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MaterialEditor.CheckerboardSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCheckerboardSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCheckerboardSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCheckerboardSettings A, FCheckerboardSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCheckerboardSettings A, FCheckerboardSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCheckerboardSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FColor ColorOne
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ColorOne, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ColorOne, __InBuffer);
				}
			}
		}

		public FColor ColorTwo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ColorTwo, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ColorTwo, __InBuffer);
				}
			}
		}

		public int Size
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Size, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Size, __InBuffer);
				}
			}
		}

		private static uint __ColorOne = 0;

		private static uint __ColorTwo = 0;

		private static uint __Size = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}