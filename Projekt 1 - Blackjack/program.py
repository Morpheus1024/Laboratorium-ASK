import sys
from PyQt5.QtWidgets import QApplication, QMainWindow, QLabel, QPushButton, QVBoxLayout, QWidget
from random import shuffle

# Klasa reprezentująca kartę
class Card:
    def __init__(self, suit, value):
        self.suit = suit
        self.value = value

    def __str__(self):
        return f"{self.value} of {self.suit}"

# Klasa reprezentująca talię kart
class Deck:
    def __init__(self):
        self.cards = []
        self.generate_deck()

    def generate_deck(self):
        suits = ['Hearts', 'Diamonds', 'Clubs', 'Spades']
        values = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A']
        self.cards = [Card(suit, value) for suit in suits for value in values]
        shuffle(self.cards)

    def draw_card(self):
        return self.cards.pop()

# Klasa reprezentująca rozgrywkę w blackjacka
class BlackjackGame:
    def __init__(self):
        self.deck = Deck()
        self.player_hand = []
        self.dealer_hand = []

    def start_game(self):
        self.deck = Deck()
        self.player_hand = [self.deck.draw_card(), self.deck.draw_card()]
        self.dealer_hand = [self.deck.draw_card(), self.deck.draw_card()]

    def hit(self, hand):
        hand.append(self.deck.draw_card())

    def calculate_hand_value(self, hand):
        total_value = 0
        num_aces = 0
        for card in hand:
            if card.value.isdigit():
                total_value += int(card.value)
            elif card.value in ['J', 'Q', 'K']:
                total_value += 10
            else:
                num_aces += 1
                total_value += 11
        while total_value > 21 and num_aces > 0:
            total_value -= 10
            num_aces -= 1
        return total_value

# Klasa reprezentująca interfejs użytkownika
class BlackjackUI(QMainWindow):
    def __init__(self):
        super().__init__()

        self.setWindowTitle("Blackjack")
        self.setGeometry(100, 100, 400, 300)

        self.central_widget = QWidget()
        self.setCentralWidget(self.central_widget)

        self.layout = QVBoxLayout()

        self.player_label = QLabel()
        self.dealer_label = QLabel()
        self.status_label = QLabel()

        self.hit_button = QPushButton("Hit")
        self.stand_button = QPushButton("Stand")
        self.new_game_button = QPushButton("New Game")

        self.hit_button.clicked.connect(self.hit)
        self.stand_button.clicked.connect(self.stand)
        self.new_game_button.clicked.connect(self.new_game)

        self.layout.addWidget(self.player_label)
        self.layout.addWidget(self.dealer_label)
        self.layout.addWidget(self.status_label)
        self.layout.addWidget(self.hit_button)
        self.layout.addWidget(self.stand_button)
        self.layout.addWidget(self.new_game_button)

        self.central_widget.setLayout(self.layout)

        self.game = BlackjackGame()
        self.new_game()

    def update_ui(self):
        player_hand_str = ", ".join(str(card) for card in self.game.player_hand)
        dealer_hand_str = ", ".join(str(card) for card in self.game.dealer_hand[:-1]) + ", [Hidden Card]"
        self.player_label.setText(f"Player's Hand: {player_hand_str}")
        self.dealer_label.setText(f"Dealer's Hand: {dealer_hand_str}")
        self.status_label.setText("")

    def hit(self):
        self.game.hit(self.game.player_hand)
        self.update_ui()
        player_value = self.game.calculate_hand_value(self.game.player_hand)
        if player_value > 21:
            self.status_label.setText("Busted! You lose.")

    def stand(self):
        dealer_value = self.game.calculate_hand_value(self.game.dealer_hand)
        while dealer_value < 17:
            self.game.hit(self.game.dealer_hand)
            dealer_value = self.game.calculate_hand_value(self.game.dealer_hand)
        self.update_ui()
        player_value = self.game.calculate_hand_value(self.game.player_hand)
        if dealer_value > 21 or player_value > dealer_value:
            self.status_label.setText("You win!")
        elif player_value == dealer_value:
            self.status_label.setText("Push!")
        else:
            self.status_label.setText("You lose.")

    def new_game(self):
        self.game.start_game()
        self.update_ui()

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = BlackjackUI()
    window.show()
    sys.exit(app.exec_())
