using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IFXPhysicalForce : CObject
	{
		[Ordinal(1)] [RED("fieldType")] 		public CEnum<EFieldType> FieldType { get; set;}

		[Ordinal(2)] [RED("simulateLocalyInEntity")] 		public CBool SimulateLocalyInEntity { get; set;}

		public IFXPhysicalForce(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}