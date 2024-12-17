using Script.CoreUObject;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.CustomizedToolMenuSection")]
	public partial class FCustomizedToolMenuSection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Slate.CustomizedToolMenuSection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCustomizedToolMenuSection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCustomizedToolMenuSection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCustomizedToolMenuSection A, FCustomizedToolMenuSection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCustomizedToolMenuSection A, FCustomizedToolMenuSection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCustomizedToolMenuSection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ECustomizedToolMenuVisibility Visibility
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Visibility, __ReturnBuffer);

					return *(ECustomizedToolMenuVisibility*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Visibility, __InBuffer);
				}
			}
		}

		private static uint __Visibility = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}