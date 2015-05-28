<root dataType="Struct" type="ScriptingPlugin.Resources.FSharpScript" id="129723834">
  <_x003C_Script_x003E_k__BackingField dataType="String">namespace Dualityscript

open ScriptingPlugin
open Duality
open Duality.Components.Renderers
open Duality.Resources

type Mega() =
    inherit DualityScript()
    
        override this.Update () =
            let changeColour (g:GameObject) =
                g.Children
                |&gt; Seq.iter (fun x -&gt; x.GetComponent&lt;SpriteRenderer&gt;().ColorTint &lt;- Color.Blue )
                ()
            let m =  Scene.Current.FindGameObject("Bricks")
            match m with
            | null -&gt; Log.Editor.Write "didnt find bricks"
            | _ -&gt; changeColour m 
            ()</_x003C_Script_x003E_k__BackingField>
  <sourcePath dataType="String">Source\Media\Mega.fs</sourcePath>
</root>
<!-- XmlFormatterBase Document Separator -->
