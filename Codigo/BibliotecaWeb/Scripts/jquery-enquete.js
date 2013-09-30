function addRow() {
    //copy the table row and clear the value of the input, then append the row to the end of the table
    var itemIndex = $("#formTable tr").length -1 ;

    var newItem = $("<tr><td>Opção "+ (itemIndex+1) +":<input id='Opcoes_" + itemIndex + "__Descricao' type='text' value='' class='text-box single-line valid'  name='Opcoes[" + itemIndex + "].Descricao' /></td></tr>");
    $("#formTable").append(newItem);

    
}