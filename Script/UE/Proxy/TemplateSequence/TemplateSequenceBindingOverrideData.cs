using Script.CoreUObject;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.TemplateSequenceBindingOverrideData")]
	public partial class FTemplateSequenceBindingOverrideData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TemplateSequence.TemplateSequenceBindingOverrideData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTemplateSequenceBindingOverrideData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTemplateSequenceBindingOverrideData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTemplateSequenceBindingOverrideData A, FTemplateSequenceBindingOverrideData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTemplateSequenceBindingOverrideData A, FTemplateSequenceBindingOverrideData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTemplateSequenceBindingOverrideData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UObject> Object
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Object, __ReturnBuffer);

					return *(TWeakObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Object, __InBuffer);
				}
			}
		}

		public bool bOverridesDefault
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverridesDefault, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverridesDefault, __InBuffer);
				}
			}
		}

		private static uint __Object = 0;

		private static uint __bOverridesDefault = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}