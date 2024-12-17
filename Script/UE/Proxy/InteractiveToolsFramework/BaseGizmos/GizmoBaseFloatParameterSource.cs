using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoBaseFloatParameterSource")]
	public partial class UGizmoBaseFloatParameterSource : UObject, IStaticClass, IGizmoFloatParameterSource
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoBaseFloatParameterSource");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetParameter(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameter, __InBuffer);
			}
		}

		/// <returns>
		/// value of parameter */
		/// </returns>
		public virtual float GetParameter()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetParameter, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void EndModify()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EndModify);
			}
		}

		public virtual void BeginModify()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __BeginModify);
			}
		}

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __SetParameter = 0;

		private static uint __GetParameter = 0;

		private static uint __EndModify = 0;

		private static uint __BeginModify = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}