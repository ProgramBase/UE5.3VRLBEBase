using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.TransformGizmoMeasurement")]
	public partial class FTransformGizmoMeasurement : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ViewportInteraction.TransformGizmoMeasurement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTransformGizmoMeasurement() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTransformGizmoMeasurement() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTransformGizmoMeasurement A, FTransformGizmoMeasurement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTransformGizmoMeasurement A, FTransformGizmoMeasurement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTransformGizmoMeasurement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UTextRenderComponent MeasurementText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeasurementText, __ReturnBuffer);

					return *(UTextRenderComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeasurementText, __InBuffer);
				}
			}
		}

		private static uint __MeasurementText = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}