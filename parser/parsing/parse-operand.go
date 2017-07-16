package parsing

import (
	"evergreen-lang/grammar"
	"evergreen-lang/grammar/ast"
	"fmt"
)

func parseOperand(tokens *TokenStateMachine) (ast.Node, error) {
	token := tokens.GetCurrent()
	switch token.LexemeType {
	case grammar.NewLine:
		return nil, fmt.Errorf("Missed expression")
	case grammar.NumericLiteral:
		return ast.NewLeafNode(ast.LeafNumber, token), nil
		break
	case grammar.Identifier:
		return ast.NewLeafNode(ast.LeafIdentifier, token), nil
		break
	}
	return nil, fmt.Errorf("Missed expression")
}