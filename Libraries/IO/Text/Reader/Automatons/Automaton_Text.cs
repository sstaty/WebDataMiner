using System;
using System.Collections.Generic;
using System.Text;
using Libraries.IO.Text.Reader.Reads;

namespace Libraries.IO.Text.Reader.Automatons
{
      public class Automaton_Text
      {
            #region Private Variables

                private HashSet<char> _charDeviders;
                private HashSet<String> _stringDeviders;

                private StringBuilder _resultBuilder;
                private String _acceptedDevider;

                private READ_UNTIL _until;
                private bool skipBeginDeviders;

            #endregion
            
            #region Construtors

                public Automaton_Text(params char[] charDeviders) : this(charDeviders, null, null) {}

                public Automaton_Text(params String[] stringDeviders) : this(null, stringDeviders, null) {}

                public Automaton_Text(params Automaton_Text[] automatons) : this(null, null, automatons) {}

                public Automaton_Text(char[] charDeviders, String[] stringDeviders, Automaton_Text[] automatons)
                {
                    CombineDevidersToThisAutomaton(charDeviders, stringDeviders, automatons);
                    Restart();
                }

            #endregion

            #region Private Methods
            
                private void CombineDevidersToThisAutomaton(char[] charDeviders, String[] stringDeviders, Automaton_Text[] automatons)
                {
                    _charDeviders.UnionWith(charDeviders);
                    _stringDeviders.UnionWith(stringDeviders);

                    foreach(Automaton_Text automaton in automatons)
                    {
                        _charDeviders.UnionWith(automaton._charDeviders);
                        _stringDeviders.UnionWith(automaton._stringDeviders);
                    }
                }

        #endregion

            #region Public Methods

                public String GetAcceptedDevider()
                {
                    return _acceptedDevider;
                }

                public String GetResult()
                {
                    return _resultBuilder.ToString();
                }

                public void Restart()
                {
                    throw new NotImplementedException();
                }

                public String GetResultAndRestart()
                {
                    String result = GetResult();
                    Restart();
                    return result;
                }

                public bool? ProccessCharacter(char? c)
                {
                    if(c is null)
                    {
                        
                    }
                    else if(_charDeviders.Contains((char)c)) 
                    {
                        _acceptedDevider = c.ToString();
                    }
                    else if()
                    {


                        return false;
                    }
                    else
                    {
                        return true;
                    }  
                }  

            #endregion

            
        }
}
