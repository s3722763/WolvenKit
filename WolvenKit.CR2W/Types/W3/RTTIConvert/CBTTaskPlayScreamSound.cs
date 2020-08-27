using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayScreamSound : IBehTreeTask
	{
		[RED("minFrequency")] 		public CFloat MinFrequency { get; set;}

		[RED("maxFrequency")] 		public CFloat MaxFrequency { get; set;}

		[RED("actor")] 		public CHandle<CActor> Actor { get; set;}

		public CBTTaskPlayScreamSound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayScreamSound(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}