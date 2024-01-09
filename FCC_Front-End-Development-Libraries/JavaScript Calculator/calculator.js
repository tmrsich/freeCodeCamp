document.addEventListener('DOMContentLoaded', function () {
    let display = document.getElementById('display');
    let currentInput = '';
    let currentOperator = '';
    let firstOperand = '';
    let secondOperand = '';
  
    const clearCalculator = () => {
      currentInput = '';
      currentOperator = '';
      firstOperand = '';
      secondOperand = '';
      updateDisplay();
    };
  
    const updateDisplay = () => {
      display.textContent = currentInput || '0';
    };
  
    const handleNumberClick = (number) => {
      if (currentInput === '0' && number === '0') {
        return; // prevent leading zeros
      }
  
      if (currentOperator === '') {
        firstOperand += number;
        currentInput = firstOperand;
      } else {
        secondOperand += number;
        currentInput = secondOperand;
      }
  
      updateDisplay();
    };
  
    const handleOperatorClick = (operator) => {
      if (currentOperator === '') {
        currentOperator = operator;
      } else {
        // Perform calculation if operator is already present
        calculateResult();
        currentOperator = operator;
      }
  
      updateDisplay();
    };
  
    const handleDecimalClick = () => {
      if (currentInput.includes('.')) {
        return; // if decimal already present, do nothing
      }
  
      if (currentOperator === '') {
        // If no operator, update the first operand
        firstOperand += '.';
        currentInput = firstOperand;
      } else {
        // If operator present, update the second operand
        secondOperand += '.';
        currentInput = secondOperand;
      }
  
      updateDisplay();
    };
  
    const calculateResult = () => {
      if (firstOperand && secondOperand) {
        const result = operate(parseFloat(firstOperand), parseFloat(secondOperand), currentOperator);
        firstOperand = result.toString();
        secondOperand = '';
        currentInput = firstOperand;
        updateDisplay();
      }
    };
  
    const operate = (operand1, operand2, operator) => {
      switch (operator) {
        case '+':
          return operand1 + operand2;
        case '-':
          return operand1 - operand2;
        case '*':
          return operand1 * operand2;
        case '/':
          return operand1 / operand2;
        default:
          return 'Error';
      }
    };
  
    const handleEqualsClick = () => {
      calculateResult();
      currentOperator = '';
    };
  
    document.getElementById('clear').addEventListener('click', clearCalculator);
    document.getElementById('divide').addEventListener('click', () => handleOperatorClick('/'));
    document.getElementById('multiply').addEventListener('click', () => handleOperatorClick('*'));
    document.getElementById('subtract').addEventListener('click', () => handleOperatorClick('-'));
    document.getElementById('add').addEventListener('click', () => handleOperatorClick('+'));
    document.getElementById('one').addEventListener('click', () => handleNumberClick('1'));
    document.getElementById('two').addEventListener('click', () => handleNumberClick('2'));
    document.getElementById('three').addEventListener('click', () => handleNumberClick('3'));
    document.getElementById('four').addEventListener('click', () => handleNumberClick('4'));
    document.getElementById('five').addEventListener('click', () => handleNumberClick('5'));
    document.getElementById('six').addEventListener('click', () => handleNumberClick('6'));
    document.getElementById('seven').addEventListener('click', () => handleNumberClick('7'));
    document.getElementById('eight').addEventListener('click', () => handleNumberClick('8'));
    document.getElementById('nine').addEventListener('click', () => handleNumberClick('9'));
    document.getElementById('zero').addEventListener('click', () => handleNumberClick('0'));
    document.getElementById('decimal').addEventListener('click', handleDecimalClick);
    document.getElementById('equals').addEventListener('click', handleEqualsClick);
  });
  